namespace Tyrizm.Forms
{
    partial class MenuForm
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
            this.FlightRegistration = new System.Windows.Forms.Button();
            this.HotelRegistration = new System.Windows.Forms.Button();
            this.UserCab = new System.Windows.Forms.Button();
            this.ShowMyTickets = new System.Windows.Forms.Button();
            this.ShowMyHotels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlightRegistration
            // 
            this.FlightRegistration.Location = new System.Drawing.Point(12, 37);
            this.FlightRegistration.Name = "FlightRegistration";
            this.FlightRegistration.Size = new System.Drawing.Size(141, 62);
            this.FlightRegistration.TabIndex = 2;
            this.FlightRegistration.Text = "Зареєструвати політ";
            this.FlightRegistration.UseVisualStyleBackColor = true;
            this.FlightRegistration.Click += new System.EventHandler(this.FlightRegistration_Click);
            // 
            // HotelRegistration
            // 
            this.HotelRegistration.Location = new System.Drawing.Point(12, 105);
            this.HotelRegistration.Name = "HotelRegistration";
            this.HotelRegistration.Size = new System.Drawing.Size(141, 62);
            this.HotelRegistration.TabIndex = 3;
            this.HotelRegistration.Text = "Забронювати Готель";
            this.HotelRegistration.UseVisualStyleBackColor = true;
            this.HotelRegistration.Click += new System.EventHandler(this.HotelRegistration_Click);
            // 
            // UserCab
            // 
            this.UserCab.Location = new System.Drawing.Point(12, 309);
            this.UserCab.Name = "UserCab";
            this.UserCab.Size = new System.Drawing.Size(141, 62);
            this.UserCab.TabIndex = 5;
            this.UserCab.Text = "Кабінет Користувача";
            this.UserCab.UseVisualStyleBackColor = true;
            this.UserCab.Click += new System.EventHandler(this.UserCab_Click);
            // 
            // ShowMyTickets
            // 
            this.ShowMyTickets.Location = new System.Drawing.Point(12, 173);
            this.ShowMyTickets.Name = "ShowMyTickets";
            this.ShowMyTickets.Size = new System.Drawing.Size(141, 62);
            this.ShowMyTickets.TabIndex = 6;
            this.ShowMyTickets.Text = "Мої квитки (авіарейси)";
            this.ShowMyTickets.UseVisualStyleBackColor = true;
            this.ShowMyTickets.Click += new System.EventHandler(this.ShowMyTickets_Click);
            // 
            // ShowMyHotels
            // 
            this.ShowMyHotels.Location = new System.Drawing.Point(12, 241);
            this.ShowMyHotels.Name = "ShowMyHotels";
            this.ShowMyHotels.Size = new System.Drawing.Size(141, 62);
            this.ShowMyHotels.TabIndex = 7;
            this.ShowMyHotels.Text = "Мої готелі (заброньовані)";
            this.ShowMyHotels.UseVisualStyleBackColor = true;
            this.ShowMyHotels.Click += new System.EventHandler(this.ShowMyHotels_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowMyHotels);
            this.Controls.Add(this.ShowMyTickets);
            this.Controls.Add(this.UserCab);
            this.Controls.Add(this.HotelRegistration);
            this.Controls.Add(this.FlightRegistration);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FlightRegistration;
        private System.Windows.Forms.Button HotelRegistration;
        private System.Windows.Forms.Button UserCab;
        private System.Windows.Forms.Button ShowMyTickets;
        private System.Windows.Forms.Button ShowMyHotels;
    }
}