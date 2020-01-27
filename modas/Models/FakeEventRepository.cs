using System;
using System.Collections.Generic;
using System.Linq;

namespace Modas.Models
{
    public class FakeEventRepository : IEventRepository
    {
        public IQueryable<Location> Locations => new List<Location>
        {
            new Location { LocationId = 1, Name = "Window" },
            new Location { LocationId = 2, Name = "Garage" },
            new Location { LocationId = 3, Name = "patio" }
        }.AsQueryable<Location>();

        public IQueryable<Event> Events => new List<Event>
        {
            new Event { TimeStamp = new DateTime(2019, 4, 19, 1, 33, 32), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 3) },
            new Event { TimeStamp = new DateTime(2019, 5, 20, 11, 28, 12), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 2) },
            new Event { TimeStamp = new DateTime(2019, 6, 1, 18, 12, 56), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 2) },
            new Event { TimeStamp = new DateTime(2019, 6, 3, 4, 00, 12), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 3) },
            new Event { TimeStamp = new DateTime(2019, 7, 25, 21, 1, 3), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 2) },
            new Event { TimeStamp = new DateTime(2019, 7, 26, 7, 15, 12), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 3) },
            new Event { TimeStamp = new DateTime(2019, 8, 24, 8, 43, 6), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 2) },
            new Event { TimeStamp = new DateTime(2019, 8, 24, 22, 05, 30), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 3) },
            new Event { TimeStamp = new DateTime(2019, 9, 1, 6, 10, 15), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 1) },
            new Event { TimeStamp = new DateTime(2019, 9, 2, 6, 5, 30), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 1) },
            new Event { TimeStamp = new DateTime(2019, 9, 3, 18, 5, 20), Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == 1) }

        }.AsQueryable<Event>();
    }
}