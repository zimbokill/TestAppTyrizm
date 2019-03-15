namespace Tyrizm.Forms
{
    partial class MyHotels
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
            this.From = new System.Windows.Forms.ComboBox();
            this.NameHotel = new System.Windows.Forms.ComboBox();
            this.ShowHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NamePerson = new System.Windows.Forms.Label();
            this.HotelName = new System.Windows.Forms.Label();
            this.RoomFormat = new System.Windows.Forms.Label();
            this.FromTo = new System.Windows.Forms.Label();
            this.ReturnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Location = new System.Drawing.Point(83, 121);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(121, 24);
            this.From.TabIndex = 0;
            this.From.SelectedIndexChanged += new System.EventHandler(this.From_SelectedIndexChanged);
            // 
            // NameHotel
            // 
            this.NameHotel.FormattingEnabled = true;
            this.NameHotel.Location = new System.Drawing.Point(313, 119);
            this.NameHotel.Name = "NameHotel";
            this.NameHotel.Size = new System.Drawing.Size(121, 24);
            this.NameHotel.TabIndex = 1;
            // 
            // ShowHotel
            // 
            this.ShowHotel.Location = new System.Drawing.Point(147, 257);
            this.ShowHotel.Name = "ShowHotel";
            this.ShowHotel.Size = new System.Drawing.Size(75, 23);
            this.ShowHotel.TabIndex = 2;
            this.ShowHotel.Text = "button1";
            this.ShowHotel.UseVisualStyleBackColor = true;
            this.ShowHotel.Click += new System.EventHandler(this.ShowHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // NamePerson
            // 
            this.NamePerson.AutoSize = true;
            this.NamePerson.Location = new System.Drawing.Point(566, 160);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(46, 17);
            this.NamePerson.TabIndex = 4;
            this.NamePerson.Text = "label2";
            // 
            // HotelName
            // 
            this.HotelName.AutoSize = true;
            this.HotelName.Location = new System.Drawing.Point(577, 240);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(46, 17);
            this.HotelName.TabIndex = 5;
            this.HotelName.Text = "label3";
            // 
            // RoomFormat
            // 
            this.RoomFormat.AutoSize = true;
            this.RoomFormat.Location = new System.Drawing.Point(577, 279);
            this.RoomFormat.Name = "RoomFormat";
            this.RoomFormat.Size = new System.Drawing.Size(46, 17);
            this.RoomFormat.TabIndex = 6;
            this.RoomFormat.Text = "label4";
            // 
            // FromTo
            // 
            this.FromTo.AutoSize = true;
            this.FromTo.Location = new System.Drawing.Point(634, 313);
            this.FromTo.Name = "FromTo";
            this.FromTo.Size = new System.Drawing.Size(46, 17);
            this.FromTo.TabIndex = 7;
            this.FromTo.Text = "label5";
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.Location = new System.Drawing.Point(371, 328);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(75, 23);
            this.ReturnMenu.TabIndex = 12;
            this.ReturnMenu.Text = "button1";
            this.ReturnMenu.UseVisualStyleBackColor = true;
            this.ReturnMenu.Click += new System.EventHandler(this.ReturnMenu_Click);
            // 
            // MyHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnMenu);
            this.Controls.Add(this.FromTo);
            this.Controls.Add(this.RoomFormat);
            this.Controls.Add(this.HotelName);
            this.Controls.Add(this.NamePerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowHotel);
            this.Controls.Add(this.NameHotel);
            this.Controls.Add(this.From);
            this.Name = "MyHotels";
            this.Text = "MyHotels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox NameHotel;
        private System.Windows.Forms.Button ShowHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NamePerson;
        private System.Windows.Forms.Label HotelName;
        private System.Windows.Forms.Label RoomFormat;
        private System.Windows.Forms.Label FromTo;
        private System.Windows.Forms.Button ReturnMenu;
    }
}