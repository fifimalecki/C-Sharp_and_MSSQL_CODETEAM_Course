using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilipMaleckiLab3
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-87K2TN0\SQLEXPRESS; database=FilipMaleckiLab3; Trusted_Connection = yes");
        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            DataTable table = Film.GetAll(connection);
            dataGridViewFilm.DataSource = table;
        }
    }
}
