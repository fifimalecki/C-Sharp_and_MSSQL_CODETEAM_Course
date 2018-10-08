namespace FilipMaleckiLab2
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
            this.labelHorseName = new System.Windows.Forms.Label();
            this.labelNumbersOfLegs = new System.Windows.Forms.Label();
            this.labelColorOfSequins = new System.Windows.Forms.Label();
            this.textBoxHorseName = new System.Windows.Forms.TextBox();
            this.textBoxNumbersOfLegs = new System.Windows.Forms.TextBox();
            this.textBoxColorOfSequins = new System.Windows.Forms.TextBox();
            this.checkBoxCorner = new System.Windows.Forms.CheckBox();
            this.buttonAddHorse = new System.Windows.Forms.Button();
            this.buttonShowHorse = new System.Windows.Forms.Button();
            this.textBoxShowHorses = new System.Windows.Forms.TextBox();
            this.dataGridViewShowUnicorns = new System.Windows.Forms.DataGridView();
            this.buttonAddUnicorn = new System.Windows.Forms.Button();
            this.buttonDeleteUnicorn = new System.Windows.Forms.Button();
            this.buttonAverageNumbersOfLegs = new System.Windows.Forms.Button();
            this.labelShowAverageNumberOfLegs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUnicorns)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(611, 343);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Filip Małecki";
            // 
            // labelHorseName
            // 
            this.labelHorseName.AutoSize = true;
            this.labelHorseName.Location = new System.Drawing.Point(13, 37);
            this.labelHorseName.Name = "labelHorseName";
            this.labelHorseName.Size = new System.Drawing.Size(69, 13);
            this.labelHorseName.TabIndex = 1;
            this.labelHorseName.Text = "Nazwa konia";
            // 
            // labelNumbersOfLegs
            // 
            this.labelNumbersOfLegs.AutoSize = true;
            this.labelNumbersOfLegs.Location = new System.Drawing.Point(12, 61);
            this.labelNumbersOfLegs.Name = "labelNumbersOfLegs";
            this.labelNumbersOfLegs.Size = new System.Drawing.Size(59, 13);
            this.labelNumbersOfLegs.TabIndex = 2;
            this.labelNumbersOfLegs.Text = "Liczba nóg";
            // 
            // labelColorOfSequins
            // 
            this.labelColorOfSequins.AutoSize = true;
            this.labelColorOfSequins.Location = new System.Drawing.Point(12, 88);
            this.labelColorOfSequins.Name = "labelColorOfSequins";
            this.labelColorOfSequins.Size = new System.Drawing.Size(74, 13);
            this.labelColorOfSequins.TabIndex = 3;
            this.labelColorOfSequins.Text = "Kolor cekinów";
            // 
            // textBoxHorseName
            // 
            this.textBoxHorseName.Location = new System.Drawing.Point(88, 35);
            this.textBoxHorseName.Name = "textBoxHorseName";
            this.textBoxHorseName.Size = new System.Drawing.Size(100, 20);
            this.textBoxHorseName.TabIndex = 4;
            // 
            // textBoxNumbersOfLegs
            // 
            this.textBoxNumbersOfLegs.Location = new System.Drawing.Point(88, 61);
            this.textBoxNumbersOfLegs.Name = "textBoxNumbersOfLegs";
            this.textBoxNumbersOfLegs.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumbersOfLegs.TabIndex = 5;
            // 
            // textBoxColorOfSequins
            // 
            this.textBoxColorOfSequins.Location = new System.Drawing.Point(88, 85);
            this.textBoxColorOfSequins.Name = "textBoxColorOfSequins";
            this.textBoxColorOfSequins.Size = new System.Drawing.Size(100, 20);
            this.textBoxColorOfSequins.TabIndex = 6;
            // 
            // checkBoxCorner
            // 
            this.checkBoxCorner.AutoSize = true;
            this.checkBoxCorner.Location = new System.Drawing.Point(13, 122);
            this.checkBoxCorner.Name = "checkBoxCorner";
            this.checkBoxCorner.Size = new System.Drawing.Size(46, 17);
            this.checkBoxCorner.TabIndex = 7;
            this.checkBoxCorner.Text = "Róg";
            this.checkBoxCorner.UseVisualStyleBackColor = true;
            // 
            // buttonAddHorse
            // 
            this.buttonAddHorse.Location = new System.Drawing.Point(13, 201);
            this.buttonAddHorse.Name = "buttonAddHorse";
            this.buttonAddHorse.Size = new System.Drawing.Size(75, 23);
            this.buttonAddHorse.TabIndex = 8;
            this.buttonAddHorse.Text = "Dodaj konia";
            this.buttonAddHorse.UseVisualStyleBackColor = true;
            this.buttonAddHorse.Click += new System.EventHandler(this.buttonAddHorse_Click);
            // 
            // buttonShowHorse
            // 
            this.buttonShowHorse.Location = new System.Drawing.Point(95, 201);
            this.buttonShowHorse.Name = "buttonShowHorse";
            this.buttonShowHorse.Size = new System.Drawing.Size(75, 23);
            this.buttonShowHorse.TabIndex = 9;
            this.buttonShowHorse.Text = "Pokaż konia";
            this.buttonShowHorse.UseVisualStyleBackColor = true;
            // 
            // textBoxShowHorses
            // 
            this.textBoxShowHorses.Location = new System.Drawing.Point(194, 9);
            this.textBoxShowHorses.Multiline = true;
            this.textBoxShowHorses.Name = "textBoxShowHorses";
            this.textBoxShowHorses.Size = new System.Drawing.Size(233, 241);
            this.textBoxShowHorses.TabIndex = 10;
            // 
            // dataGridViewShowUnicorns
            // 
            this.dataGridViewShowUnicorns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowUnicorns.Location = new System.Drawing.Point(439, 12);
            this.dataGridViewShowUnicorns.Name = "dataGridViewShowUnicorns";
            this.dataGridViewShowUnicorns.Size = new System.Drawing.Size(270, 150);
            this.dataGridViewShowUnicorns.TabIndex = 11;
            // 
            // buttonAddUnicorn
            // 
            this.buttonAddUnicorn.Location = new System.Drawing.Point(439, 168);
            this.buttonAddUnicorn.Name = "buttonAddUnicorn";
            this.buttonAddUnicorn.Size = new System.Drawing.Size(75, 38);
            this.buttonAddUnicorn.TabIndex = 12;
            this.buttonAddUnicorn.Text = "Dodaj jednorożca";
            this.buttonAddUnicorn.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUnicorn
            // 
            this.buttonDeleteUnicorn.Location = new System.Drawing.Point(520, 168);
            this.buttonDeleteUnicorn.Name = "buttonDeleteUnicorn";
            this.buttonDeleteUnicorn.Size = new System.Drawing.Size(75, 38);
            this.buttonDeleteUnicorn.TabIndex = 13;
            this.buttonDeleteUnicorn.Text = "Usuń jednorożca";
            this.buttonDeleteUnicorn.UseVisualStyleBackColor = true;
            // 
            // buttonAverageNumbersOfLegs
            // 
            this.buttonAverageNumbersOfLegs.Location = new System.Drawing.Point(601, 168);
            this.buttonAverageNumbersOfLegs.Name = "buttonAverageNumbersOfLegs";
            this.buttonAverageNumbersOfLegs.Size = new System.Drawing.Size(75, 38);
            this.buttonAverageNumbersOfLegs.TabIndex = 14;
            this.buttonAverageNumbersOfLegs.Text = "Średnia ilość nóg";
            this.buttonAverageNumbersOfLegs.UseVisualStyleBackColor = true;
            // 
            // labelShowAverageNumberOfLegs
            // 
            this.labelShowAverageNumberOfLegs.AutoSize = true;
            this.labelShowAverageNumberOfLegs.Location = new System.Drawing.Point(436, 211);
            this.labelShowAverageNumberOfLegs.Name = "labelShowAverageNumberOfLegs";
            this.labelShowAverageNumberOfLegs.Size = new System.Drawing.Size(137, 13);
            this.labelShowAverageNumberOfLegs.TabIndex = 15;
            this.labelShowAverageNumberOfLegs.Text = "Wyświetla średnią ilość nóg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 377);
            this.Controls.Add(this.labelShowAverageNumberOfLegs);
            this.Controls.Add(this.buttonAverageNumbersOfLegs);
            this.Controls.Add(this.buttonDeleteUnicorn);
            this.Controls.Add(this.buttonAddUnicorn);
            this.Controls.Add(this.dataGridViewShowUnicorns);
            this.Controls.Add(this.textBoxShowHorses);
            this.Controls.Add(this.buttonShowHorse);
            this.Controls.Add(this.buttonAddHorse);
            this.Controls.Add(this.checkBoxCorner);
            this.Controls.Add(this.textBoxColorOfSequins);
            this.Controls.Add(this.textBoxNumbersOfLegs);
            this.Controls.Add(this.textBoxHorseName);
            this.Controls.Add(this.labelColorOfSequins);
            this.Controls.Add(this.labelNumbersOfLegs);
            this.Controls.Add(this.labelHorseName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUnicorns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHorseName;
        private System.Windows.Forms.Label labelNumbersOfLegs;
        private System.Windows.Forms.Label labelColorOfSequins;
        private System.Windows.Forms.TextBox textBoxHorseName;
        private System.Windows.Forms.TextBox textBoxNumbersOfLegs;
        private System.Windows.Forms.TextBox textBoxColorOfSequins;
        private System.Windows.Forms.CheckBox checkBoxCorner;
        private System.Windows.Forms.Button buttonAddHorse;
        private System.Windows.Forms.Button buttonShowHorse;
        private System.Windows.Forms.TextBox textBoxShowHorses;
        private System.Windows.Forms.DataGridView dataGridViewShowUnicorns;
        private System.Windows.Forms.Button buttonAddUnicorn;
        private System.Windows.Forms.Button buttonDeleteUnicorn;
        private System.Windows.Forms.Button buttonAverageNumbersOfLegs;
        private System.Windows.Forms.Label labelShowAverageNumberOfLegs;
    }
}

