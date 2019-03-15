namespace Tyrizm.Forms
{
    partial class ValidationHotel
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
            this.Menubut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HotelName = new System.Windows.Forms.Label();
            this.Person = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.RoomFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menubut
            // 
            this.Menubut.Location = new System.Drawing.Point(603, 359);
            this.Menubut.Name = "Menubut";
            this.Menubut.Size = new System.Drawing.Size(103, 53);
            this.Menubut.TabIndex = 0;
            this.Menubut.Text = "Перейти в меню";
            this.Menubut.UseVisualStyleBackColor = true;
            this.Menubut.Click += new System.EventHandler(this.Menubut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Готель заброньовано на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дні перебування";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип кімнати";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Назва готелю";
            // 
            // HotelName
            // 
            this.HotelName.AutoSize = true;
            this.HotelName.Location = new System.Drawing.Point(510, 62);
            this.HotelName.Name = "HotelName";
            this.HotelName.Size = new System.Drawing.Size(46, 17);
            this.HotelName.TabIndex = 5;
            this.HotelName.Text = "label5";
            // 
            // Person
            // 
            this.Person.AutoSize = true;
            this.Person.Location = new System.Drawing.Point(510, 127);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(46, 17);
            this.Person.TabIndex = 6;
            this.Person.Text = "label6";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(510, 193);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(46, 17);
            this.Date.TabIndex = 7;
            this.Date.Text = "label7";
            // 
            // RoomFormat
            // 
            this.RoomFormat.AutoSize = true;
            this.RoomFormat.Location = new System.Drawing.Point(510, 262);
            this.RoomFormat.Name = "RoomFormat";
            this.RoomFormat.Size = new System.Drawing.Size(46, 17);
            this.RoomFormat.TabIndex = 8;
            this.RoomFormat.Text = "label8";
            // 
            // ValidationHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomFormat);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.HotelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menubut);
            this.Name = "ValidationHotel";
            this.Text = "ValidationHotel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ValidationHotel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menubut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HotelName;
        private System.Windows.Forms.Label Person;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label RoomFormat;
    }
}