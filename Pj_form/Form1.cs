using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pj4;
namespace Pj_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Locations l = new Locations();
            l.GetLocations();

            //List<Location> locations = l.GetLocations();
            foreach (Location s in l.GetLocations())
            {
                Console.WriteLine(s.name);
            }

        }

    }
}
