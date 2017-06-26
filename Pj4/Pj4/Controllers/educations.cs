using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pj4.Models;

namespace Pj4
{
    public class Educations
    {
        public List<Education> educations;
        public Educations()
        {
            GenerateEducationList();
        }
        public Option<Education> GetEducation(int id)
        {
            var obj = educations.Find(x => x.id == id);
            if (obj == null)
            {
                return new None<Education>();
            }
            else
            {
                return new Some<Education>(obj);
            }
        }
        public Option<Education> GetEducation(string name)
        {
            var obj = educations.Find(x => x.name == name);
            if (obj == null)
            {
                return new None<Education>();
            }
            else
            {
                return new Some<Education>(obj);
            }
        }
        public void GenerateEducationList()
        {
            educations = new List<Education>();
            educations.Add(new Education(1 , "Informatica" , "short desc" , "Long descc"));
        }
    }
}
