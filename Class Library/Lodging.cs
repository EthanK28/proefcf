using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        public decimal MilesFromNearestAirport { get; set; }


        public int LocationId { get; set; }

        

        //[Required]
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }

        public List<InternetSpecial> InternetSpecials { get; set; }

        

        

        //[InverseProperty("PrimaryContactFor")]
        public Person PrimaryContact { get; set; }
        //[InverseProperty("SecondaryContactFor")]
        public Person SecondaryContact { get; set; }
    }
}