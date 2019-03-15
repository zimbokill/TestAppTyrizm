using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class ValidationHotel : Form
    {
        public ValidationHotel()
        {
            InitializeComponent();
            InsertLinq insertLinq = new InsertLinq();
            var hotel=insertLinq.GetHotel();
            foreach (var h in hotel)
            {
                if (h.HName+h.HNameHotel+h.HRoomFormat+h.HFrom+h.HTo==HotelForm.Counter)
                {
                    HotelName.Text = h.HNameHotel;
                    RoomFormat.Text = h.HRoomFormat;
                    Date.Text = h.HFrom + "-" + h.HTo;
                    Person.Text = h.HName;
                }
            }
        }

        private void Menubut_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.Show();
        }

        private void ValidationHotel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
