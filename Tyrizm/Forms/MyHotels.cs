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
    public partial class MyHotels : Form
    {
        InsertLinq insertLinq = new InsertLinq();  
        public MyHotels()
        {
            InitializeComponent();
            var hotel = insertLinq.GetHotel();
            foreach (var h in hotel)
            {
                if (h.Hash==LoginForm.Counter)
                From.Items.Add(h.HFrom);
            }
        }

        private void From_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hotel = insertLinq.GetHotel();
            foreach (var h in hotel)
            { if (h.Hash == LoginForm.Counter)
                    if( h.HFrom==From.SelectedItem.ToString())
                    NameHotel.Items.Add(h.HNameHotel);
            }
        }

        private void ShowHotel_Click(object sender, EventArgs e)
        {
            var hotel = insertLinq.GetHotel();
            foreach( var h in hotel)
            {
                if (h.Hash == LoginForm.Counter)
                    if (From.SelectedItem.ToString() + NameHotel.SelectedItem.ToString() == h.HFrom + h.HNameHotel)
                {
                    NamePerson.Text = h.HName;
                    HotelName.Text = h.HNameHotel;
                    RoomFormat.Text = h.HRoomFormat;
                    FromTo.Text = h.HFrom + "-" + h.HTo;
                }
            }
        }

        private void ReturnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            Hide();
            menuForm.Show();
        }
    }
}
