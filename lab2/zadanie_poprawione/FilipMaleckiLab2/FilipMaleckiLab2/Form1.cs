using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FilipMaleckiLab2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Listę koni
        /// </summary>
        private List<Horse> listOfHorses;
        /// <summary>
        /// Lista jednorożców
        /// </summary>
        private List<Unicorn> listOfUnicorns;

        public Form1()
        {
            InitializeComponent();
            listOfHorses = new List<Horse>();
            listOfUnicorns = new List<Unicorn>();
        }
        /// <summary>
        /// Obsługa przycisku dodającego konia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddHorse_Click(object sender, EventArgs e)
        {
            AddHorse();
        }
        /// <summary>
        /// Funkcja dodająca nowego konia
        /// </summary>
        private void AddHorse()
        {
            try
            {
                var horse = new Horse
                {
                Name = textBoxHorseName.Text,
                NumberOfLegs = Int32.Parse(textBoxNumbersOfLegs.Text)
                };
            listOfHorses.Add(horse);

            }
            catch(FormatException)
            {
                MessageBox.Show("Podaj wszystkie informacje we właściwym formacie!");
            }
        }
        /// <summary>
        /// Funkcja pokazująca konie
        /// </summary>
        private void ShowHorse()
        {
            try
            {
                textBoxShowHorses.Text = "";
                for (int i = 0; i < listOfHorses.Count; i++)
                    textBoxShowHorses.Text += "Kuń " + listOfHorses[i].Name + " co mo liczba nóg: " + listOfHorses[i].NumberOfLegs + "\r\n";
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Ni mo wincyj koniów..");
            }

        }
        /// <summary>
        /// Obsługa przycisku do pokazywania koni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowHorse_Click(object sender, EventArgs e)
        {
            ShowHorse();
        }
        /// <summary>
        /// Obsługa przycisku dodającego jednorożca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUnicorn_Click(object sender, EventArgs e)
        {
            AddUnicorn();
        }
        /// <summary>
        /// Funkcja dodająca nowego jednorożca
        /// </summary>
        private void AddUnicorn()
        {
            try
            {
                var unicorn = new Unicorn
                {
                    Name = textBoxHorseName.Text,
                    NumberOfLegs = Int32.Parse(textBoxNumbersOfLegs.Text),
                    ColorOfSequins = textBoxColorOfSequins.Text,
                    Corner = checkBoxCorner.Checked
                };
                listOfUnicorns.Add(unicorn);
                dataGridViewShowUnicorns.Rows.Add(unicorn.Name, unicorn.NumberOfLegs, unicorn.ColorOfSequins, unicorn.Corner);
            }
            catch(FormatException)
            {
                MessageBox.Show("Podaj wszystkie informacje we właściwym formacie!");
            }
        }
        /// <summary>
        /// Obsługa przycisku usuwającego jednorożca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteUnicorn_Click(object sender, EventArgs e)
        {
            DeleteUnicorn();
        }
        /// <summary>
        /// Funkcja usuwająca jednorożca z dataGridView i listy jednorożców
        /// </summary>
        private void DeleteUnicorn()
        {
            foreach (DataGridViewRow item in this.dataGridViewShowUnicorns.SelectedRows)
            {
                string unicornId = (string)dataGridViewShowUnicorns[0, item.Index].Value;
                var unicorn = listOfUnicorns.FirstOrDefault(p => p.Name == unicornId);
                if (unicorn != null)
                    listOfUnicorns.Remove(unicorn);

                dataGridViewShowUnicorns.Rows.RemoveAt(item.Index);
            }
        }
        /// <summary>
        /// Obsługa przycisku wyliczającego średnią ilość nóg i wyświetlającego wynik w labelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAverageNumbersOfLegs_Click(object sender, EventArgs e)
        {
            labelShowAverageNumberOfLegs.Text = CalculateAverageNumberOfLegs().ToString();
        }
        /// <summary>
        /// Funkcja obliczająca średnią ilość nóg
        /// </summary>
        /// <returns></returns>
        private double CalculateAverageNumberOfLegs()
        {

            double averageNumbersOfLegs = 0.0;
            double numberOfHorsesLegs = 0;
            double numberOfUnicornsLegs = 0;

            foreach (Horse horse in listOfHorses)
                numberOfHorsesLegs += horse.NumberOfLegs;
            foreach (Unicorn unicorn in listOfUnicorns)
                numberOfUnicornsLegs += unicorn.NumberOfLegs;

            averageNumbersOfLegs = (numberOfUnicornsLegs + numberOfHorsesLegs) / (listOfHorses.Count + listOfUnicorns.Count);

            return averageNumbersOfLegs;
        }
    }
}
