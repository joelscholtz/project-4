using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pj4;
namespace Pj4
{
    public class Location
    {
        public int id;
        public int education_id;
        public string name;
        public double x_coord;
        public double y_coord;

        public Location(int id, int education_id, string name, double x_coord, double y_coord)
        {
            this.id = id;
            this.education_id = education_id;
            this.name = name;
            this.x_coord = x_coord;
            this.y_coord = y_coord;
        }
    } 
}
