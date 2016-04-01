using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        public Person()
        {
            Address = new Address();
            Info = new PersonalInfo
            {
                Weight = new Measurement(),
                Height = new Measurement()
            };
            
        }
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        
        [ConcurrencyCheck]
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[Timestamp]
        //public byte[] RowVersion { get; set; }
        public Address Address { get; set; }

        public PersonalInfo Info { get; set; }

    }


}
