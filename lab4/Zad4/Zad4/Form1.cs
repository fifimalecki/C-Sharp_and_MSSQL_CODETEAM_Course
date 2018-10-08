using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Zad4
{
    public partial class Form1 : Form
    {   /// <summary>
        /// ???
        /// </summary>
        DataClasses1DataContext context = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja pokazująca klientów
        /// </summary>
        private void ShowCustomers()
        {
            var customers = from customer in context.Customers
                            select new {Nazwa = customer.Name,
                                        Ulica = customer.StreetAdress,
                                        Numer_Budynku = customer.BuildingNumber,
                                        Miasto = customer.City,
                                        Kod_Pocztowy = customer.PostalCode,
                                        Państwo = customer.Country,
                                        Email = customer.Email,
                                        Phone = customer.Phone};
            dataGridViewShow.DataSource = customers;
        }
        /// <summary>
        /// Lista pokazująca liste zamówionych produktów
        /// </summary>
        /// <param name="index"></param>
        private void ShowProductList(decimal index)
        {
            var productLists = from productList in context.ProductLists
                               join product in context.Products on productList.ProductID equals product.ID
                               where productList.ID == index
                               select new
                               {
                                   ProductID = productList.ProductID,
                                   Nazwa = product.Name,
                                   Ilość = productList.Quantity,
                                   Wartość = product.Value * productList.Quantity
                            };
            dataGridViewShow.DataSource = productLists;
        }
        /// <summary>
        /// Obsługa przycisku dodania nowego Klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = textBoxName.Text;
            customer.StreetAdress = textBoxStreet.Text;
            customer.BuildingNumber = textBoxBuildingNumber.Text;
            customer.City = textBoxCity.Text;
            customer.PostalCode = textBoxPostalCode.Text;
            customer.Country = textBoxCountry.Text;
            customer.Email = textBoxEmail.Text;
            customer.Phone = textBoxPhone.Text;

            context.Customers.InsertOnSubmit(customer);
            context.SubmitChanges();

            ShowCustomers();
        }
        /// <summary>
        /// Obsługa przycisku usunięcia Klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = (from element in context.Customers
                         where element.Name == textBoxName.Text
                         orderby element.ID descending
                         select element).FirstOrDefault();

            context.Customers.DeleteOnSubmit(customer);
            context.SubmitChanges();

            ShowCustomers();
        }
        /// <summary>
        /// Obsługa przycisku wyświetlającego klientów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowCustomers_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }
        /// <summary>
        /// Obsługa zdarzenia przy zaznaczeniu wiersza związanego z klientem i podstawienie danych do textboxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewShow.Rows[e.RowIndex];

                textBoxName.Text = row.Cells[0].Value.ToString();
                textBoxStreet.Text = row.Cells[1].Value.ToString();
                textBoxBuildingNumber.Text = row.Cells[2].Value.ToString();
                textBoxCity.Text = row.Cells[3].Value.ToString();
                textBoxPostalCode.Text = row.Cells[4].Value.ToString();
                textBoxCountry.Text = row.Cells[5].Value.ToString();
                textBoxEmail.Text = row.Cells[6].Value.ToString();
                textBoxPhone.Text = row.Cells[7].Value.ToString();
            }
        }
        /// <summary>
        /// Funkcja zapisująca datagridview do pliku .csv
        /// </summary>
        /// <param name="DGV"></param>
        private void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "Output.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Nie udało się stowrzyć pliku." + ex.Message);
                    }
                }
                int columnCount = DGV.ColumnCount;
                string columnNames = "";
                string[] output = new string[DGV.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += DGV.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < DGV.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(saveFileDialog.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Plik został zapisany");
            }
        }
        /// <summary>
        /// Obsługa przycisku zapisującego do pliku csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveToCsv_Click(object sender, EventArgs e)
        {
            SaveToCSV(dataGridViewShow);
        }
        /// <summary>
        /// Funckja zapisująca "fakturę"
        /// </summary>
        private void SaveInvoice()
        {
            string filename = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT (*.txt)|*.txt";
            saveFileDialog.FileName = "Output.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Nie udało się stowrzyć pliku." + ex.Message);
                    }
                }
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("\t\t\t\tWrocław,"+DateTime.Now.Day+"."+DateTime.Now.Month+"."+DateTime.Now.Year);
                    writer.WriteLine("\t\tORYGINAŁ");
                    writer.WriteLine("Nabywca:");
                    writer.WriteLine(textBoxName.Text);
                    writer.WriteLine(textBoxPostalCode.Text + textBoxCity.Text + " ,ul." + textBoxStreet.Text +" "+ textBoxBuildingNumber.Text);
                    writer.WriteLine("lp.\tNazwa towaru\tilość\tWartość Netto");
                    for(int i = 0; i < dataGridViewShow.RowCount; i++)
                    {
                        writer.WriteLine((i+1).ToString()+"\t"+dataGridViewShow.Rows[i].Cells[1].Value.ToString()+"\t\t"+ dataGridViewShow.Rows[i].Cells[2].Value.ToString()+"\t"+dataGridViewShow.Rows[i].Cells[3].Value.ToString());
                    }
                }
            }
                MessageBox.Show("Plik został zapisany");
            }
        /// <summary>
        /// Obsługa przycisku zapisującego fakturę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveInvoice_Click(object sender, EventArgs e)
        {
            SaveInvoice();
        }
        /// <summary>
        /// Obsługa przycisku pokazującego zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowOrder_Click(object sender, EventArgs e)
        {
            ShowProductList(numericUpDownOrderID.Value);
        }
    }
}
