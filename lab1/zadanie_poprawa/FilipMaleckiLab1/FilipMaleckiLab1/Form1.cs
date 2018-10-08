using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilipMaleckiLab1
{
    public partial class FormMain : Form
    {
        /// <sumary>
        /// counter - zmienna ktora wyswietla wartosc
        /// </sumary>
        int counter = 0;
        ///<sumary>
        /// a - pierwszy skladnik dodawania
        /// b - drugi skladnik dodawania
        /// wynik - wynik dodawania a i b
        /// </sumary>
        int a;
        int b;
        int wynik;
        /// <sumary>
        /// formFunction - nowe okno
        /// </sumary>
        FormFunction formFunction = new FormFunction();
        public FormMain()
        {
            InitializeComponent();
            timerCounter.Start();
        }
        ///<sumary>
        ///---------------Funkcja obslugujaca przycisk start
        ///</sumary>
        private void buttonStart_click(object sender, EventArgs e)
        {
                this.BackColor = Color.Red;
                buttonStart.BackColor = Color.Yellow;
        }
        ///<sumary>
        ///---------------Funkcja obslugujaca przycisk stop
        ///</sumary>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            buttonStop.BackColor = Color.Green;
        }
        /// <summary>
        /// Funkcja obslugująca przycisk zmien
        /// </summary>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            labelName.Text = "Wartość " + counter;
            counter += Int32.Parse(textBoxResult.Text);
        }
        /// <summary>
        /// Funckja obslugujaca przycisk oblicz
        /// </summary>
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(textBoxA.Text);
            b = Int32.Parse(textBoxB.Text);

            wynik = a + b;

            labelResult.Text = wynik.ToString();
        }
        /// <summary>
        /// obsluga zdarzenia zmiany czasu w timerze
        /// </summary>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            counter++;
            textBoxTimer.Text = counter.ToString();
            if (counter % 2 == 0)
                BackColor = Color.DarkBlue;
            else BackColor = Color.White;
        }
        /// <summary>
        /// obsluga zdarzenia otwarcia nowego okna przyciskiem otworz okno
        /// </summary>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
                formFunction.Show();
        }
    }
}
