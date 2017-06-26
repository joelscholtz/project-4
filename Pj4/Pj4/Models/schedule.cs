using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public class Schedule
    {
        public int id;
        public int education_id;
        public string start_dt;
        public string stop_dt;
        public string activity_desc;

        public Schedule(int id, int education_id, string start_dt, string stop_dt, string activity_desc)
        {
            this.id = id;
            this.education_id = education_id;
            this.start_dt = start_dt;
            this.stop_dt = stop_dt;
            this.activity_desc = activity_desc;
        }
    }
}
