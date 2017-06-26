using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public class Location
    {
        public int id;
        public int education_id;
        public string name;
        public string x_coord;
        public string y_coord;

        public Location(int id , int education_id , string name , string x_coord , string y_coord)
        {
            this.id = id;
            this.education_id = education_id;
            this.name = name;
            this.x_coord = x_coord;
            this.y_coord = y_coord;
        }

    }
}
