using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrizm.DataBases
{
    [Table(Name = "Person")]
    class Person
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]       
        public int id { get; set; }       
        [Column]
        public int Hash { get; set; }
       
        [Column]
        [Required(ErrorMessage = "Не вказано логін користувача")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Недопустима довжина логіна")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Не вказано прізвище користувача")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустима довжина  прізвища")]
        [Column]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Не вказано ім'я користувача")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Недопустима довжина  ім'я")]
        [Column]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не вказано прізвище користувача")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустима довжина  прізвища")]
        [Column]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Не вказано прізвище користувача")]
        [ Range(1, 100, ErrorMessage = "Недопустимий вік. Має бути в межах 1-100")]
        [Column]
        public int Age { get; set; }
        [Required(ErrorMessage = "Не вказано стать користувача")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустима стать")]
        [Column]
        public string Sex { get; set; }
        [EmailAddress(ErrorMessage = "Недопустимий формат Email-адреси")]
        [Column]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не вказано місто проживання")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустиме ім'я  міста")]
        [Column]
        public string City { get; set; }
        [Required(ErrorMessage = "Не вказано номер телефону")]
        [RegularExpression(@"^\+380\d{3}\d{2}\d{2}\d{2}$", ErrorMessage = "Номер телефона должен иметь формат +xxxx-xxx-xx-xx")]
        [Column]
        public string PhoneNumber { get; set; }
    }
}
