using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataLayerForFluent
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name).IsRequired();
            Property(d => d.Description).HasMaxLength(2000);
            Property(d => d.Photo).HasColumnType("image");

            //HasMany(d => d.Lodgings)
            //    .WithRequired(l => l.Destination); 

        }

     
    }

    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(l => l.Name).IsRequired().HasMaxLength(2000);
            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 1);

        }
    }






}
