
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
   
    public class Locations<T>
    {
        Location loc;
        List<Location> locs;
        public Locations(Location loc)
        {
            this.loc = loc;
        }
        public void SetLocation(string x_coord , string y_coord)
        {
            
        }
        public Option<Location> GetLocation(int education_id)
        {
            
        }
        
        public List<Option<Location>> GetLocations()
        {
           // return new Some<Location>(List<Location>());
        }
        public void GenerateLocationList()
        {
            locs.Add(new Location(1 , 1 , "Wijnhaven" , 10.0 , 10.5));
            
        }
    }

}
