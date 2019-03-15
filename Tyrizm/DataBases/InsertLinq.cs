using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Tyrizm.DataBases
{
    class InsertLinq
    {
        static string connectionString = @"Data Source=desktop-4cp3n74;Initial Catalog=Tyrizm;Integrated Security=True";
        DataContext db = new DataContext(connectionString);
        public void Insert(Person person)
        {            
            db.GetTable<Person>().InsertOnSubmit(person);
            db.SubmitChanges();
        }
      
        public void Insert(Tickets tickets)
        {
            db.GetTable<Tickets>().InsertOnSubmit(tickets);
            db.SubmitChanges();
        }
        public void Insert(Hotel hotel)
        {
            db.GetTable<Hotel>().InsertOnSubmit(hotel);
            db.SubmitChanges();
        }
        public Table<Person> GetPeople()
        {
            Table<Person> person = db.GetTable<Person>();
            return person;
        }
        public Table<Hotel> GetHotel()
        {
            Table<Hotel> hotel = db.GetTable<Hotel>();
            return hotel;
        }
       
        public Table<HotelList> GetHotelList()
        {
            Table<HotelList> hotels = db.GetTable<HotelList>();     
            return hotels;
        }
        public Table<RoomList> GetRoomsList()
        {
            Table<RoomList> roomLists = db.GetTable<RoomList>();
            return roomLists;
        }
     
        public Table<Companys> GetCompany()
        {
            Table<Companys> companys = db.GetTable<Companys>();
            return companys;
        }
        public Table<Tickets> GetTickets()
        {
            Table<Tickets> tickets = db.GetTable<Tickets>();
            return tickets;
        }


        public void Change(string Surname, string Name, string SecondName, string Age, string Sex, string PhoneNumber, string CityField, string Email)
        {
            DataContext db = new DataContext(connectionString);
            Table<Person> person1 = db.GetTable<Person>();
            var selectperson = from p in person1
                               where p.Hash == Forms.LoginForm.Counter
                               select p;
            foreach (var person in selectperson)
            {
                person.SurName = Surname;
                person.Name = Name;
                person.SecondName = SecondName;
                person.Age = Convert.ToInt32(Age);
                person.Sex = Sex;
                person.PhoneNumber =PhoneNumber;
                person.City = CityField;
                person.Email = Email;                
            }
            db.SubmitChanges();

            
        }
        public void Change(int Hash, string Surname, string Name, string SecondName, string Age, string Sex, string PhoneNumber, string CityField, string Email)
        {
            DataContext db = new DataContext(connectionString);
            Table<Person> person1 = db.GetTable<Person>();
            var selectperson = from p in person1
                               where p.Hash == Forms.LoginForm.Counter
                               select p;
            foreach (var person in selectperson)
            {
                person.Hash = Hash;
                person.SurName = Surname;
                person.Name = Name;
                person.SecondName = SecondName;
                person.Age = Convert.ToInt32(Age);
                person.Sex = Sex;
                person.PhoneNumber = PhoneNumber;
                person.City = CityField;
                person.Email = Email;
            }
            db.SubmitChanges();


        }
    }
}
