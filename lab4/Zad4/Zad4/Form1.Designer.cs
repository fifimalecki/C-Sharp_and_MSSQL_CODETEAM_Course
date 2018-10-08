namespace Zad4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxBuildingNumber = new System.Windows.Forms.TextBox();
            this.labelBuildingNumber = new System.Windows.Forms.Label();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonShowCustomers = new System.Windows.Forms.Button();
            this.buttonSaveInvoice = new System.Windows.Forms.Button();
            this.buttonShowOrder = new System.Windows.Forms.Button();
            this.numericUpDownOrderID = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveToCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderID)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nazwa Firmy";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(142, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(142, 39);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreet.TabIndex = 3;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(14, 41);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(31, 13);
            this.labelStreet.TabIndex = 2;
            this.labelStreet.Text = "Ulica";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(142, 97);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 5;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(14, 99);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Miasto";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(316, 11);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountry.TabIndex = 7;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(248, 13);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(48, 13);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Państwo";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(316, 37);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(248, 37);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(316, 61);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 11;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(248, 61);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(43, 13);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Telefon";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(142, 126);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 15;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(14, 130);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(74, 13);
            this.labelPostalCode.TabIndex = 14;
            this.labelPostalCode.Text = "Kod pocztowy";
            // 
            // textBoxBuildingNumber
            // 
            this.textBoxBuildingNumber.Location = new System.Drawing.Point(142, 68);
            this.textBoxBuildingNumber.Name = "textBoxBuildingNumber";
            this.textBoxBuildingNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuildingNumber.TabIndex = 13;
            // 
            // labelBuildingNumber
            // 
            this.labelBuildingNumber.AutoSize = true;
            this.labelBuildingNumber.Location = new System.Drawing.Point(14, 69);
            this.labelBuildingNumber.Name = "labelBuildingNumber";
            this.labelBuildingNumber.Size = new System.Drawing.Size(82, 13);
            this.labelBuildingNumber.TabIndex = 12;
            this.labelBuildingNumber.Text = "Numer budynku";
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(12, 212);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.Size = new System.Drawing.Size(518, 220);
            this.dataGridViewShow.TabIndex = 16;
            this.dataGridViewShow.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewShow_RowHeaderMouseClick);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(12, 171);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(99, 35);
            this.buttonAddCustomer.TabIndex = 0;
            this.buttonAddCustomer.Text = "Dodaj Klienta";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(117, 171);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(99, 35);
            this.buttonDeleteCustomer.TabIndex = 1;
            this.buttonDeleteCustomer.Text = "Usuń Klienta";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.ButtonDeleteCustomer_Click);
            // 
            // buttonShowCustomers
            // 
            this.buttonShowCustomers.Location = new System.Drawing.Point(222, 171);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(99, 35);
            this.buttonShowCustomers.TabIndex = 2;
            this.buttonShowCustomers.Text = "Wyświetl Klientów";
            this.buttonShowCustomers.UseVisualStyleBackColor = true;
            this.buttonShowCustomers.Click += new System.EventHandler(this.ButtonShowCustomers_Click);
            // 
            // buttonSaveInvoice
            // 
            this.buttonSaveInvoice.Location = new System.Drawing.Point(536, 397);
            this.buttonSaveInvoice.Name = "buttonSaveInvoice";
            this.buttonSaveInvoice.Size = new System.Drawing.Size(102, 35);
            this.buttonSaveInvoice.TabIndex = 4;
            this.buttonSaveInvoice.Text = "Zapisz Fakturę";
            this.buttonSaveInvoice.UseVisualStyleBackColor = true;
            this.buttonSaveInvoice.Click += new System.EventHandler(this.ButtonSaveInvoice_Click);
            // 
            // buttonShowOrder
            // 
            this.buttonShowOrder.Location = new System.Drawing.Point(431, 171);
            this.buttonShowOrder.Name = "buttonShowOrder";
            this.buttonShowOrder.Size = new System.Drawing.Size(99, 35);
            this.buttonShowOrder.TabIndex = 17;
            this.buttonShowOrder.Text = "Zamówienie";
            this.buttonShowOrder.UseVisualStyleBackColor = true;
            this.buttonShowOrder.Click += new System.EventHandler(this.ButtonShowOrder_Click);
            // 
            // numericUpDownOrderID
            // 
            this.numericUpDownOrderID.Location = new System.Drawing.Point(367, 180);
            this.numericUpDownOrderID.Name = "numericUpDownOrderID";
            this.numericUpDownOrderID.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownOrderID.TabIndex = 18;
            this.numericUpDownOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSaveToCsv
            // 
            this.buttonSaveToCsv.Location = new System.Drawing.Point(536, 356);
            this.buttonSaveToCsv.Name = "buttonSaveToCsv";
            this.buttonSaveToCsv.Size = new System.Drawing.Size(102, 35);
            this.buttonSaveToCsv.TabIndex = 19;
            this.buttonSaveToCsv.Text = "Zapisz do pliku CSV";
            this.buttonSaveToCsv.UseVisualStyleBackColor = true;
            this.buttonSaveToCsv.Click += new System.EventHandler(this.ButtonSaveToCsv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.buttonSaveToCsv);
            this.Controls.Add(this.numericUpDownOrderID);
            this.Controls.Add(this.buttonShowOrder);
            this.Controls.Add(this.buttonSaveInvoice);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.buttonShowCustomers);
            this.Controls.Add(this.textBoxBuildingNumber);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.labelBuildingNumber);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "\"Faktura\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxBuildingNumber;
        private System.Windows.Forms.Label labelBuildingNumber;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonShowCustomers;
        private System.Windows.Forms.Button buttonSaveInvoice;
        private System.Windows.Forms.Button buttonShowOrder;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderID;
        private System.Windows.Forms.Button buttonSaveToCsv;
    }
}

