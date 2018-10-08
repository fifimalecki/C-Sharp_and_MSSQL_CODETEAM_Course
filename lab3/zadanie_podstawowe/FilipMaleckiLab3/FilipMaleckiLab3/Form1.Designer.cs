namespace FilipMaleckiLab3
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
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.buttonFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(426, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(198, 37);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Filip Małecki";
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.Size = new System.Drawing.Size(399, 341);
            this.dataGridViewFilm.TabIndex = 1;
            // 
            // buttonFilm
            // 
            this.buttonFilm.Location = new System.Drawing.Point(433, 49);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(191, 23);
            this.buttonFilm.TabIndex = 2;
            this.buttonFilm.Text = "Wszystkie Filmy";
            this.buttonFilm.UseVisualStyleBackColor = true;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 365);
            this.Controls.Add(this.buttonFilm);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Button buttonFilm;
    }
}

