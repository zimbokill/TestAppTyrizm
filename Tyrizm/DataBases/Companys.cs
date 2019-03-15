using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrizm.DataBases
{
    [Table(Name = "Companys")]
    class Companys
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        //public int id { get; set; }
        [Column]
        public string  Company { get; set; }
        
    }
}
