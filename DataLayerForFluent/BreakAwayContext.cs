using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLayerForFluent
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        
        

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());

            modelBuilder.Entity<Trip>()
                .HasKey(t => t.Identifier)
                .Property(t => t.Identifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<InternetSpecial>()
                .HasRequired(s => s.Accomodation)
                .WithMany(l => l.InternetSpecials);

            //modelBuilder.Entity<Destination>()
            //    .HasMany(d => d.Lodgings)
            //    .WithRequired()
            //    .HasForeignKey(l => l.LodgingId);

            //modelBuilder.Entity<Person>()
            //    .HasKey(p => p.SocialSecurityNumber);
            //modelBuilder.Entity<Person>()
            //    .Property(p => p.SocialSecurityNumber)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            //modelBuilder.Entity<Person>()
            //    .Property(p => p.RowVersion).IsRowVersion();




            //modelBuilder.Entity<Trip>().HasKey(t => t.Identifier);
            //modelBuilder.Entity<Destination>().Property(d => d.Name).IsRequired();
            //modelBuilder.Entity<Destination>().Property(d => d.Description).HasMaxLength(900);
            //modelBuilder.Entity<Destination>().Property(d => d.Photo).HasColumnType("image");

            //modelBuilder.Entity<Lodging>().Property(l => l.Name).IsRequired().HasMaxLength(500);

        }
    }
}
