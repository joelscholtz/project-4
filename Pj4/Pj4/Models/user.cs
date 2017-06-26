using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public class User
    {
        int id;
        string fullname;
        string email;
        string address;

        public User(int id, string fullname, string email, string address)
        {
            this.id = id;
            this.fullname = fullname;
            this.email = email;
            this.address = address;
        }
    }
}
