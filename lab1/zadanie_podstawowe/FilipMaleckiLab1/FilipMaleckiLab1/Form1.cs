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
        /// <summary>
        /// counter - zmienna ktora wyswietla wartosc 
        /// </summary>
        int counter = 0;
        /// <summary>
        /// a - pierwszy skladnik dodawania
        /// </summary>
        int a;
        /// <summary>
        /// b - drugi skladnik dodawania
        /// </summary>
        int b;
        /// <summary>
        /// wynik - wynik dodawania a i b
        /// </summary>
        int wynik;
        /// <summary>
        /// formFunction - nowe okno
        /// </summary>
        FormFunction formFunction = new FormFunction();
        public FormMain()
        {
            InitializeComponent();
            timerCounter.Start();
        }

        ///
        ///<sumary>
        ///---------------Funkcja obslugujaca przycisk start
        ///</sumary>
        private void buttonStart_click(object sender, EventArgs e)
        {
                this.BackColor = Color.Red;
                buttonStart.BackColor = Color.Yellow;
        }

        ///
        ///<sumary>
        ///---------------Funkcja obslugujaca przycisk stop
        ///</sumary>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            buttonStop.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funkcja obslugująca przycisk zmien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            labelName.Text = "Wartość " + counter;
            counter += Int32.Parse(textBoxResult.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funckja obslugujaca przycisk oblicz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
                formFunction.Show();
        }
    }
}
