using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class InternetSpecial
    {
        public int InternetSpecialID { get; set; }
        public int Nights { get; set; }
        public decimal CostUSD { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        //[ForeignKey("Accomodation")]
        public int AccomodationId { get; set; }
        public Lodging Accomodation { get; set; }
    }
}
