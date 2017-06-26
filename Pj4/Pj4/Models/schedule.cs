using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4.Models
{
    public class schedule <T>: Option<T>
    {
        int id;
        int education_id;
        string start_dt;
        string stop_dt;
        string activity_desc;

        public schedule(int id, int education_id, string start_dt, string stop_dt, string activity_desc)
        {
            this.id = id;
            this.education_id = education_id;
            this.start_dt = start_dt;
            this.stop_dt = stop_dt;
            this.activity_desc = activity_desc;
        }
        
            
        public void Visit(Action onNone, Action<T> onSome)
            {
                throw new NotImplementedException();
            }

        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
            {
                throw new NotImplementedException();
            }
    }
}
