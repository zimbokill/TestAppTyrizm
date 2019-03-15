using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyrizm.DataBases
{
    [Table(Name = "Tickets")]
    class Tickets
    {                  
            [Column(IsPrimaryKey = true, IsDbGenerated = true)]
            public int id { get; set; }
            [Column]
            public int Hash { get; set; }
            [Column]
            public string TName { get; set; }
            [Column]
            public string TTo { get; set; }
            [Column]
            public string TFrom { get; set; }
            [Column]
            public string TCompany { get; set; }
            [Column]
            public string TDateFlight { get; set; }
            [Column]
            public string TConveniense { get; set; }
            [Column]
            public string TGate { get; set; }
            [Column]
            public string TSeat { get; set; }
            [Column]
            public string TBoardingTime { get; set; }
            [Column]
            public string TFlightNumber { get; set; }
        
    }
}

