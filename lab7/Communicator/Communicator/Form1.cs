using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Communicator
{
    public partial class FormMain : Form
    {
        CommunicationDataClassesDataContext context = new CommunicationDataClassesDataContext();
        /// <summary>
        /// Zmienna globalna przechowująca login zalogowanego użytkownika
        /// </summary>
        string currentLogin;
        /// <summary>
        /// Zmienna globalna przechowująca ID zalogowanego użytkownika
        /// </summary>
        int currentUserID;

        public FormMain()
        {
            InitializeComponent();
            // Pierwsze uruchomienie funkcji do pokazania wiadomości i dostępnych użytkowników bez wyświetlania powiadomień
            ShowMessages(false);
            ShowOnlineUsers();
            // Wystartowanie zegara
            timerResfreshingData.Start();
            // Przypisanie zmiennych po zalogowaniu na chat
            currentLogin = FormLogin.GetLogin;
            currentUserID = FormLogin.GetUserID;
            // Po uruchomieniu okienka aktywuj textBox do pisania wiadomości
            this.ActiveControl = textBoxNewMessage;
            // Włączenie opcji online na serwerze
            var userLogin = from users in context.FilipMalecki_Users
                            where (users.ID == currentUserID)
                            select users;
            foreach(FilipMalecki_User element in userLogin)
            {
                element.Online = true;
                context.SubmitChanges();
            }
            // Scroll wiadomości na sam dół
            textBoxMessages.SelectionStart = textBoxMessages.TextLength;
            textBoxMessages.ScrollToCaret();
            
        }
        /// <summary>
        /// Funkcja wylogowująca użytkownika z serwera. Ustawianie atrybutu offline
        /// </summary>
        private void LogOutUser()
        {
            var user = from users in context.FilipMalecki_Users
                       where (users.ID == currentUserID)
                       select users;
            foreach (FilipMalecki_User element in user)
            {
                element.Online = false;
                context.SubmitChanges();
            }
        }
        /// <summary>
        /// Funkcja wysyłająca na serwer nową wiadomość
        /// </summary>
        private void AddText()
        {
            string message = textBoxNewMessage.Text;

            FilipMalecki_Converstation newMessage = new FilipMalecki_Converstation()
            {   
                    Message = message,
                    UserId = currentUserID,
                    Time = DateTime.Now.ToString("HH:mm:ss")   
            };
            textBoxNewMessage.Text = "";
            context.FilipMalecki_Converstations.InsertOnSubmit(newMessage);
            context.SubmitChanges();
            
        }
        #region Zmiana pozycji okna drag-n-drop
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion
        /// <summary>
        /// Funkcja wyświetlająca wiadomośći z serwera
        /// </summary>
        private void ShowMessages(bool showBalloonTipFlag)
        {
            var message = from messages in context.FilipMalecki_Converstations
                          select messages;
            foreach(FilipMalecki_Converstation element in message)
            {
                if (!textBoxMessages.Text.Contains("[" + element.Time.ToString() + "][ " + element.FilipMalecki_User.Login.ToString() + " ]\r\n" + element.Message.ToString() + "\r\n"))
                {
                    textBoxMessages.AppendText("[" + element.Time.ToString() + "][ " + element.FilipMalecki_User.Login.ToString() + " ]\r\n" + element.Message.ToString() + "\r\n");
                    if (element.UserId != currentUserID && this.Visible == false && showBalloonTipFlag == true)
                        notifyIcon.ShowBalloonTip(1000, element.FilipMalecki_User.Login.ToString(), element.Message.ToString(), ToolTipIcon.Info);
                }
            }
        }
        /// <summary>
        /// Funkcja pokazująca użytkowników online i usuwająca użytkowników offline
        /// </summary>
        private void ShowOnlineUsers()
        {
            var online = from users in context.FilipMalecki_Users
                         where (users.Online == true)
                         select users;
            foreach(FilipMalecki_User element in online)
            {
                if(!listBoxOnlineUsers.Items.Contains("[ " + element.Login + " ]"))
                    listBoxOnlineUsers.Items.Add("[ " + element.Login + " ]");
            }
            var offline = from users in context.FilipMalecki_Users
                          where (users.Online == false)
                          select users;
            foreach(FilipMalecki_User element in offline)
            {
                if (listBoxOnlineUsers.Items.Contains("[ " + element.Login + " ]"))
                {
                    listBoxOnlineUsers.Items.Remove("[ " + element.Login + " ]");
                }
            }
        }
        /// <summary>
        /// Funkcja obsługująca przycisk zamykający okno i chat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogOutUser();
        }
        /// <summary>
        /// Obsługa zdarzenia działającego timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerResfreshingData_Tick(object sender, EventArgs e)
        {
            ShowOnlineUsers();
            // Wyświetlanie wiadomości + powiadomienia jeśli okno jest zminimalizowane do tray'a
            ShowMessages(true);
        }
        /// <summary>
        /// Funkcja obsługująca przycisk zamkykania okna i chatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            LogOutUser();
            Application.Exit();
        }
        /// <summary>
        /// Funkcja obsługująca wysyłanie wiadomości zapomocą przycisku Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNewMessageKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) AddText();
        }
        /// <summary>
        /// Funkcja obsługująca przycisk Wyślij
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            AddText();
        }
        /// <summary>
        /// Funkcja obsługująca przycisk Minimalizacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinimalize_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
        }
        /// <summary>
        /// Funkcja obsługująca dwukrotne kliknięcie w ikonę tray'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
