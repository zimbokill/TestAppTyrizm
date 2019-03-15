using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Tyrizm.DataBases
{
    [Table(Name = "Hotels")]
    class Hotel
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column]
        public int Hash { get; set; }
        [Column]
        public string HName { get; set; }
        [Column]
        public string HNameHotel { get; set; }
        [Column]
        public string HRoomFormat { get; set; }
        [Column]
        public string HFrom { get; set; }
        [Column]
        public string HTo { get; set; }

    }
}
