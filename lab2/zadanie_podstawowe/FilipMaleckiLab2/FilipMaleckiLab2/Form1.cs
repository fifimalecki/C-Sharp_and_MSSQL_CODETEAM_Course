using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilipMaleckiLab2
{
    public partial class Form1 : Form
    {
        private List<Horse> listOfHorses;
        private List<Unicorn> listOfUnicorns;

        public Form1()
        {
            InitializeComponent();
            listOfHorses = new List<Horse>();
            listOfUnicorns = new List<Unicorn>();
        }

        private void buttonAddHorse_Click(object sender, EventArgs e)
        {
            AddHorse();
        }

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
    }
}
