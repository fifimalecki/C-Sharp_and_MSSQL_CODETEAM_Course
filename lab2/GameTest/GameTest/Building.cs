using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTest
{
    public abstract class Building
    {
        /// <summary>
        /// Poziom budynku
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Funkcja obsługująca proces rozbudowy budynku
        /// </summary>
        /// <param name="progressBar"></param>
        /// <param name="timer"></param>
        /// <param name="button"></param>
        /// <returns></returns>
        protected bool UpgradeProgress(ProgressBar progressBar, Timer timer, Button button)
        {
            progressBar.Visible = true; // Pokaż progressBar
            timer.Start(); // Wystratuj timer budowy
            button.Text = "Ukończ budowę"; // Zmień wyświetlany tekst z "Rozbuduj" na "Ukończ budowę"
            if (progressBar.Value == progressBar.Maximum) // Jeśli processBar osiągnie Maximum
            {
                timer.Interval += 100; // Zwiększ długość budowy
                timer.Stop(); // Zatrzymaj timer budowy
                return true; 
            }
            else return false;
        }
        /// <summary>
        /// Funkcja odpowiedzialna za rozbudowe
        /// </summary>
        /// <param name="pBar1"></param>
        /// <param name="timer"></param>
        /// <param name="button"></param>
        /// <param name="pictureBox"></param>
        /// <param name="imageList"></param>
        public virtual void Upgrade(ProgressBar progressBar, Timer timer,Button button, PictureBox pictureBox, ImageList imageList)
        {
            MessageBox.Show("Level up");
        }
        
    }
}
