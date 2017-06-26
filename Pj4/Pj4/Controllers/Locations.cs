using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public class Locations
    {
        //Location loc;
        public List<Location> locs;
        public Locations()
        {
            GenerateLocationList();
        }

        public Option<Location> GetLocation(int education_id)
        {
            // Find location in list by education_id
            var obj = locs.Find(x => x.education_id == education_id);
            if (obj == null)
            {
                return new None<Location>();
            }
            else
            {
                return new Some<Location>(obj);
            }
        }
        public List<Location> GetLocations()
        {

          return locs;
        }
        public void GenerateLocationList()
            {
                // Generate List
                locs = new List<Location>();
                locs.Add(new Location(1, 1, "Wijnhaven 109", 10, 10));
                locs.Add(new Location(2, 1, "Wijnhaven 112", 10, 10));
                locs.Add(new Location(3, 3, "Dijkzicht 11", 20, 20));
                locs.Add(new Location(4, 4, "Coolhaven 121", 30, 30));

            }
        }

    }