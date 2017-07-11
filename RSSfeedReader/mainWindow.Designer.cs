namespace RSSfeedReader
{
    partial class mainWindow
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
            this.OsvjeziGumb = new System.Windows.Forms.Button();
            this.OdabirNaslovaComboBox = new System.Windows.Forms.ComboBox();
            this.IdiNaLbl = new System.Windows.Forms.LinkLabel();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.RSSfeedPorukaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OsvjeziGumb
            // 
            this.OsvjeziGumb.Location = new System.Drawing.Point(505, 8);
            this.OsvjeziGumb.Name = "OsvjeziGumb";
            this.OsvjeziGumb.Size = new System.Drawing.Size(60, 25);
            this.OsvjeziGumb.TabIndex = 0;
            this.OsvjeziGumb.Text = "Unesi";
            this.OsvjeziGumb.UseVisualStyleBackColor = true;
            this.OsvjeziGumb.Click += new System.EventHandler(this.OsvjeziGumb_Click);
            // 
            // OdabirNaslovaComboBox
            // 
            this.OdabirNaslovaComboBox.FormattingEnabled = true;
            this.OdabirNaslovaComboBox.Location = new System.Drawing.Point(12, 38);
            this.OdabirNaslovaComboBox.Name = "OdabirNaslovaComboBox";
            this.OdabirNaslovaComboBox.Size = new System.Drawing.Size(553, 21);
            this.OdabirNaslovaComboBox.TabIndex = 1;
            this.OdabirNaslovaComboBox.SelectedIndexChanged += new System.EventHandler(this.OdabirNaslovaComboBox_SelectedIndexChanged);
            // 
            // IdiNaLbl
            // 
            this.IdiNaLbl.AutoSize = true;
            this.IdiNaLbl.Location = new System.Drawing.Point(9, 288);
            this.IdiNaLbl.Name = "IdiNaLbl";
            this.IdiNaLbl.Size = new System.Drawing.Size(36, 13);
            this.IdiNaLbl.TabIndex = 2;
            this.IdiNaLbl.TabStop = true;
            this.IdiNaLbl.Text = "Idi na:";
            this.IdiNaLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IdiNaLbl_LinkClicked);
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(179, 11);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(320, 20);
            this.channelTextBox.TabIndex = 3;
            // 
            // RSSfeedPorukaTextBox
            // 
            this.RSSfeedPorukaTextBox.Location = new System.Drawing.Point(12, 65);
            this.RSSfeedPorukaTextBox.Multiline = true;
            this.RSSfeedPorukaTextBox.Name = "RSSfeedPorukaTextBox";
            this.RSSfeedPorukaTextBox.Size = new System.Drawing.Size(553, 215);
            this.RSSfeedPorukaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unesite željeni RSS link :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RSSfeedPorukaTextBox);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.IdiNaLbl);
            this.Controls.Add(this.OdabirNaslovaComboBox);
            this.Controls.Add(this.OsvjeziGumb);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OsvjeziGumb;
        private System.Windows.Forms.ComboBox OdabirNaslovaComboBox;
        private System.Windows.Forms.LinkLabel IdiNaLbl;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox RSSfeedPorukaTextBox;
        private System.Windows.Forms.Label label1;
    }
}