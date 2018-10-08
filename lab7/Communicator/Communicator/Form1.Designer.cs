namespace Communicator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel8 = new System.Windows.Forms.Panel();
            this.listBoxOnlineUsers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxNewMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerResfreshingData = new System.Windows.Forms.Timer(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.buttonMinimalize = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.listBoxOnlineUsers);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(148, 311);
            this.panel8.TabIndex = 1;
            // 
            // listBoxOnlineUsers
            // 
            this.listBoxOnlineUsers.BackColor = System.Drawing.Color.Black;
            this.listBoxOnlineUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOnlineUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBoxOnlineUsers.FormattingEnabled = true;
            this.listBoxOnlineUsers.Location = new System.Drawing.Point(3, 5);
            this.listBoxOnlineUsers.Name = "listBoxOnlineUsers";
            this.listBoxOnlineUsers.Size = new System.Drawing.Size(142, 299);
            this.listBoxOnlineUsers.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(518, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 317);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.buttonSend);
            this.panel7.Controls.Add(this.textBoxNewMessage);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(497, 30);
            this.panel7.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.Color.Green;
            this.buttonSend.Location = new System.Drawing.Point(431, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(63, 24);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // textBoxNewMessage
            // 
            this.textBoxNewMessage.BackColor = System.Drawing.Color.Black;
            this.textBoxNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxNewMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxNewMessage.Location = new System.Drawing.Point(3, 9);
            this.textBoxNewMessage.Name = "textBoxNewMessage";
            this.textBoxNewMessage.Size = new System.Drawing.Size(422, 13);
            this.textBoxNewMessage.TabIndex = 0;
            this.textBoxNewMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNewMessageKeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(12, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.textBoxMessages);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(531, 269);
            this.panel6.TabIndex = 3;
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.BackColor = System.Drawing.Color.Black;
            this.textBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxMessages.Location = new System.Drawing.Point(3, 3);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(520, 260);
            this.textBoxMessages.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(12, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 275);
            this.panel3.TabIndex = 2;
            // 
            // timerResfreshingData
            // 
            this.timerResfreshingData.Tick += new System.EventHandler(this.TimerResfreshingData_Tick);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Green;
            this.buttonClose.Location = new System.Drawing.Point(630, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 14);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "x";
            this.toolTip.SetToolTip(this.buttonClose, "Zamknij");
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelProgramName.Location = new System.Drawing.Point(297, 11);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(91, 13);
            this.labelProgramName.TabIndex = 9;
            this.labelProgramName.Text = "Super Turbo Chat";
            // 
            // buttonMinimalize
            // 
            this.buttonMinimalize.BackColor = System.Drawing.Color.Blue;
            this.buttonMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimalize.ForeColor = System.Drawing.Color.Green;
            this.buttonMinimalize.Location = new System.Drawing.Point(586, 10);
            this.buttonMinimalize.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMinimalize.Name = "buttonMinimalize";
            this.buttonMinimalize.Size = new System.Drawing.Size(42, 14);
            this.buttonMinimalize.TabIndex = 10;
            this.buttonMinimalize.Text = "_";
            this.toolTip.SetToolTip(this.buttonMinimalize, "Minimalizuj");
            this.buttonMinimalize.UseVisualStyleBackColor = false;
            this.buttonMinimalize.Click += new System.EventHandler(this.ButtonMinimalize_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Super Turbo Chat";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 365);
            this.Controls.Add(this.buttonMinimalize);
            this.Controls.Add(this.labelProgramName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxNewMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Timer timerResfreshingData;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxOnlineUsers;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonMinimalize;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

