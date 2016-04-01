using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
//using DataAccess;
using System.Data.Entity;
using DataLayerForFluent;

namespace BreakAwayConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<BreakAwayContext>());
            InsertDestination();
            InsertTrip();
            InsertPerson();
            UpdateTrip();
            UpdatePerson();

            // DeleteDestinationInMemoryAndDbCascade();
        }

        private static void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                Name = "Bali"
            };
            using (var context = new DataLayerForFluent.BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }

        private static void InsertTrip()
        {
            var trip = new Trip
            {
                CostUDS = 800,
                StartDate = new DateTime(2011, 9, 1),
                EndDate = new DateTime(2011, 9, 14)
            };

            using (var context = new BreakAwayContext())
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }
        }

        private static void InsertPerson()
        {
            var person = new Person
            {
                FirstName = "Rowan",
                LastName = "Miller",
                SocialSecurityNumber = 123455678,
                Photo = new PersonPhoto { Photo = new Byte[] { 0 } }
            };
            using (var context = new BreakAwayContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        private static void UpdateTrip()
        {
            using (var context = new BreakAwayContext())
            {
                var trip = context.Trips.FirstOrDefault();
                trip.CostUDS = 700;
                context.SaveChanges();
            }
        }

        private static void UpdatePerson()
        {
            using (var context = new BreakAwayContext())
            {
                var person = context.People.FirstOrDefault();
                person.FirstName = "Rowena";
                if (person.Photo == null)
                {
                    person.Photo = new PersonPhoto { Photo = new Byte[] { 0 } };       
                }
                context.SaveChanges();
            }
        }

        //private static void DeleteDestinationInMemoryAndDbCascade()
        //{
        //    int destinationId;
        //    using (var context = new BreakAwayContext())
        //    {
        //        var destination = new Destination
        //        {
        //            Name = "Sample Destination",
        //            Lodgings = new List<Lodging>
        //              {
        //                new Lodging { Name = "Lodging One" },
        //                new Lodging { Name = "Lodging Two" }
        //              }
        //        };
        //        context.Destinations.Add(destination);
        //        context.SaveChanges();
        //        destinationId = destination.DestinationId;
        //    }

            //using (var context = new BreakAwayContext())
            //{
            //    var destination = context.Destinations
            //        .Include("Lodgings")
            //        .Single(d => d.DestinationId == destinationId);

            //    var aLodging = destination.Lodgings.FirstOrDefault();
            //    context.Destinations.Remove(destination);

            //    Console.WriteLine("State of one Lodging: {0}", context.Entry(aLodging).State.ToString());

            //    context.SaveChanges();
            //}

        //    using (var context = new BreakAwayContext())
        //    {
        //        var destination = context.Destinations
        //          .Single(d => d.DestinationId == destinationId);
                              
        //        context.Destinations.Remove(destination);
        //        context.SaveChanges();
        //    }
        //    using (var context = new BreakAwayContext())
        //    {
        //        var lodgings = context.Lodgings
        //          .Where(l => l.DestinationId == destinationId).ToList();
        //        Console.WriteLine("Lodgings: {0}", lodgings.Count);
        //    }
        //}



    }
}
