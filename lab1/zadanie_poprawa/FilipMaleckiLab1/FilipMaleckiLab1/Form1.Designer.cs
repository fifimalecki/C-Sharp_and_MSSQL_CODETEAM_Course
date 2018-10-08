namespace FilipMaleckiLab1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelDigit = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelEquation = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(13, 42);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.labelName.Location = new System.Drawing.Point(217, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(261, 55);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Fifi Malecki";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(59, 71);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(165, 71);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Zmien";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelDigit
            // 
            this.labelDigit.AutoSize = true;
            this.labelDigit.Location = new System.Drawing.Point(12, 74);
            this.labelDigit.Name = "labelDigit";
            this.labelDigit.Size = new System.Drawing.Size(41, 13);
            this.labelDigit.TabIndex = 5;
            this.labelDigit.Text = "Liczba:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(12, 115);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 6;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(118, 118);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(13, 13);
            this.labelPlus.TabIndex = 7;
            this.labelPlus.Text = "+";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(138, 114);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 8;
            // 
            // labelEquation
            // 
            this.labelEquation.AutoSize = true;
            this.labelEquation.Location = new System.Drawing.Point(245, 120);
            this.labelEquation.Name = "labelEquation";
            this.labelEquation.Size = new System.Drawing.Size(13, 13);
            this.labelEquation.TabIndex = 9;
            this.labelEquation.Text = "=";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(265, 120);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Wynik";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(12, 142);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 11;
            this.buttonSolve.Text = "Oblicz";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(378, 252);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimer.TabIndex = 12;
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(403, 223);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonNewWindow.TabIndex = 13;
            this.buttonNewWindow.Text = "Nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 284);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEquation);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelDigit);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelDigit;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelEquation;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

