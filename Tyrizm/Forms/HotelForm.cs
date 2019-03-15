using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyrizm.DataBases;

namespace Tyrizm.Forms
{
    public partial class HotelForm : Form
    {
        InsertLinq insertLinq = new InsertLinq();

        public HotelForm()
        {
         
            InitializeComponent();
            var hotels = insertLinq.GetHotelList();
            var rooms = insertLinq.GetRoomsList();
            var people = insertLinq.GetPeople();

            foreach (var h in hotels) { HotelName.Items.Add(h.HotelName); }
            foreach (var r in rooms) { RoomFormat.Items.Add(r.RoomType); }
            foreach (var p in people)
            {
                if (p.Hash == LoginForm.Counter)
                {
                    Person.Text = p.Name+" "+p.SurName+" "+p.SecondName;
                 }
            }

        }
        public static string Counter;
        private void HotelRegistration_Click(object sender, EventArgs e)
        {
            Hotel h = new Hotel()
            {
                Hash = LoginForm.Counter,
                HName = Person.Text,
                HNameHotel = HotelName.SelectedItem.ToString(),
                HRoomFormat = RoomFormat.SelectedItem.ToString(),
                HFrom = DataFrom.Text.ToString(),
                HTo = DataTo.Text.ToString()
            };
            insertLinq.Insert(h);
            Counter = Person.Text+ HotelName.SelectedItem.ToString() + RoomFormat.SelectedItem.ToString() + DataFrom.Text.ToString() + DataTo.Text.ToString();
            ValidationHotel validationHotel = new ValidationHotel();
            Hide();
            validationHotel.Show();
        }

        private void HotelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
