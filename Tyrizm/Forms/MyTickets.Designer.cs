namespace Tyrizm.Forms
{
    partial class MyTickets
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
            this.FromToList = new System.Windows.Forms.ComboBox();
            this.ShowInformation = new System.Windows.Forms.Button();
            this.FlightNumber = new System.Windows.Forms.Label();
            this.FromTo = new System.Windows.Forms.Label();
            this.DateBoarding = new System.Windows.Forms.Label();
            this.SeatCLass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NamePasenger = new System.Windows.Forms.Label();
            this.TimeList = new System.Windows.Forms.ComboBox();
            this.ReturnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromToList
            // 
            this.FromToList.FormattingEnabled = true;
            this.FromToList.Location = new System.Drawing.Point(221, 121);
            this.FromToList.Name = "FromToList";
            this.FromToList.Size = new System.Drawing.Size(121, 24);
            this.FromToList.TabIndex = 0;
            // 
            // ShowInformation
            // 
            this.ShowInformation.Location = new System.Drawing.Point(145, 261);
            this.ShowInformation.Name = "ShowInformation";
            this.ShowInformation.Size = new System.Drawing.Size(75, 23);
            this.ShowInformation.TabIndex = 1;
            this.ShowInformation.Text = "button1";
            this.ShowInformation.UseVisualStyleBackColor = true;
            this.ShowInformation.Click += new System.EventHandler(this.ShowInformation_Click);
            // 
            // FlightNumber
            // 
            this.FlightNumber.AutoSize = true;
            this.FlightNumber.Location = new System.Drawing.Point(509, 124);
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Size = new System.Drawing.Size(46, 17);
            this.FlightNumber.TabIndex = 2;
            this.FlightNumber.Text = "label1";
            // 
            // FromTo
            // 
            this.FromTo.AutoSize = true;
            this.FromTo.Location = new System.Drawing.Point(509, 178);
            this.FromTo.Name = "FromTo";
            this.FromTo.Size = new System.Drawing.Size(46, 17);
            this.FromTo.TabIndex = 3;
            this.FromTo.Text = "label2";
            // 
            // DateBoarding
            // 
            this.DateBoarding.AutoSize = true;
            this.DateBoarding.Location = new System.Drawing.Point(509, 225);
            this.DateBoarding.Name = "DateBoarding";
            this.DateBoarding.Size = new System.Drawing.Size(46, 17);
            this.DateBoarding.TabIndex = 4;
            this.DateBoarding.Text = "label3";
            // 
            // SeatCLass
            // 
            this.SeatCLass.AutoSize = true;
            this.SeatCLass.Location = new System.Drawing.Point(509, 267);
            this.SeatCLass.Name = "SeatCLass";
            this.SeatCLass.Size = new System.Drawing.Size(46, 17);
            this.SeatCLass.TabIndex = 5;
            this.SeatCLass.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Інформація про вибраний рейс";
            // 
            // NamePasenger
            // 
            this.NamePasenger.AutoSize = true;
            this.NamePasenger.Location = new System.Drawing.Point(509, 332);
            this.NamePasenger.Name = "NamePasenger";
            this.NamePasenger.Size = new System.Drawing.Size(46, 17);
            this.NamePasenger.TabIndex = 6;
            this.NamePasenger.Text = "label8";
            // 
            // TimeList
            // 
            this.TimeList.FormattingEnabled = true;
            this.TimeList.Location = new System.Drawing.Point(33, 121);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(121, 24);
            this.TimeList.TabIndex = 10;
            this.TimeList.SelectedIndexChanged += new System.EventHandler(this.TimeList_SelectedIndexChanged);
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.Location = new System.Drawing.Point(193, 365);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(75, 23);
            this.ReturnMenu.TabIndex = 11;
            this.ReturnMenu.Text = "button1";
            this.ReturnMenu.UseVisualStyleBackColor = true;
            this.ReturnMenu.Click += new System.EventHandler(this.ReturnMenu_Click);
            // 
            // MyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnMenu);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NamePasenger);
            this.Controls.Add(this.SeatCLass);
            this.Controls.Add(this.DateBoarding);
            this.Controls.Add(this.FromTo);
            this.Controls.Add(this.FlightNumber);
            this.Controls.Add(this.ShowInformation);
            this.Controls.Add(this.FromToList);
            this.Name = "MyTickets";
            this.Text = "MyTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FromToList;
        private System.Windows.Forms.Button ShowInformation;
        private System.Windows.Forms.Label FlightNumber;
        private System.Windows.Forms.Label FromTo;
        private System.Windows.Forms.Label DateBoarding;
        private System.Windows.Forms.Label SeatCLass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NamePasenger;
        private System.Windows.Forms.ComboBox TimeList;
        private System.Windows.Forms.Button ReturnMenu;
    }
}