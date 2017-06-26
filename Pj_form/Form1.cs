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
<<<<<<< HEAD
            // DEBUG WORKING 
            Locations  l = new Locations();
            l.GetLocations();
           
            //List<Location> locations = l.GetLocations();
            foreach (Location  s in l.GetLocations())
            {
                Console.WriteLine(s.name);
            }
            var test = l.GetLocation(1222);
            // END WORKING
=======

            Locations l = new Locations();
            l.GetLocations();

            //List<Location> locations = l.GetLocations();
            foreach (Location s in l.GetLocations())
            {
                Console.WriteLine(s.name);
            }

>>>>>>> a99f2b6beabb2abdd479de6ce6615529ce0eb3ec
        }

    }
}
