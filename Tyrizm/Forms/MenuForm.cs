using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyrizm.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void FlightRegistration_Click(object sender, EventArgs e)
        {
            FlightForm flightForm = new FlightForm();
            Hide();
            flightForm.Show();
            
        }

        private void HotelRegistration_Click(object sender, EventArgs e)
        {
            HotelForm hotelForm = new HotelForm();
            Hide();
            hotelForm.Show();
        }

        private void ShowMyTickets_Click(object sender, EventArgs e)
        {
            MyTickets myTickets = new MyTickets();
            Hide();
            myTickets.Show();
        }

        private void ShowMyHotels_Click(object sender, EventArgs e)
        {
            MyHotels myHotels = new MyHotels();
            Hide();
            myHotels.Show();
        }

        private void UserCab_Click(object sender, EventArgs e)
        {
            UserCabinet userCabinet = new UserCabinet();
            Hide();
            userCabinet.Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    
    }
}
