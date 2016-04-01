using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataLayerForFluent
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {

        }
    }
}