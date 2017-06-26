using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public class Education
    {
        public int id;
        public string name;
        public string short_desc;
        public string long_desc;

        public Education(int id, string name, string short_desc, string long_desc)
        {
            this.id = id;
            this.name = name;
            this.short_desc = short_desc;
            this.long_desc = long_desc;
        }
    }
}
