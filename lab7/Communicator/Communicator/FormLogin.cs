using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Communicator
{
    public partial class FormLogin : Form
    {
        CommunicationDataClassesDataContext context = new CommunicationDataClassesDataContext();
        /// <summary>
        /// Zmienna statyczna przechowująca Login logowanego użytkownika
        /// </summary>
        static string Login;
        /// <summary>
        /// Zmienna statyczna przechowująca ID logowanego użytkownika
        /// </summary>
        static int userID;

        public FormLogin()
        {
            InitializeComponent();
            
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
        /// Funkcja logująca użytkownika na serwer. Ustawianie atrybutu online
        /// </summary>
        private void LogInUser()
        {
            var user = from users in context.FilipMalecki_Users
                       where (users.Login == textBoxLogin.Text)
                       select users;
            foreach (FilipMalecki_User element in user)
            {
                if (textBoxPassword.Text == element.Password)
                {
                    this.Hide();
                    element.Online = true;
                    Login = element.Login;
                    userID = element.ID;
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();

                    context.SubmitChanges();
                }
            }
        }
        /// <summary>
        /// Funkcja dodająca nowego użytkownika
        /// </summary>
        private void AddNewUser()
        {
            FilipMalecki_User newUser = new FilipMalecki_User()
            {
                Login = textBoxLogin.Text.ToString(),
                Password = textBoxPassword.Text.ToString(),
                Online = false
            };

            context.FilipMalecki_Users.InsertOnSubmit(newUser);
            context.SubmitChanges();

            MessageBox.Show("Użytkownik " + newUser.Login + " został dodany!");
        }
        /// <summary>
        /// Obsługa przycisku dodającego nowego użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }
        /// <summary>
        /// Obsługa przycisku logującego na serwer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            LogInUser();
        }
        /// <summary>
        /// Funkcja zwracająca Login logującego się na serwer
        /// </summary>
        static public string GetLogin
        {
            get { return Login; }
        }
        /// <summary>
        /// Funkcja zwracająca ID logującego się na serwer
        /// </summary>
        static public int GetUserID
        {
            get { return userID; }
        }
        /// <summary>
        /// Obsługa przycisku zamykającego okno logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Funkcja obsługująca logowanie się po wciśnięciu przycisku Enter mając aktywne pole wpisywania hasła
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) { LogInUser(); }
        }
    }
}
