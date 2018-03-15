using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaExercisesOO
{
    class Hobo : Person
    {
        // This constructor will call Person.Person(string, string, string)
        public Hobo(string pFirstName, string pLastName, string pGender) : base (pFirstName, pLastName, pGender)
        {
                  
        }

        // This constructor will call Person.Person(string)
        public Hobo(string pGender) : base(pGender)
        {
            
        }

        public override string Work()
        {
            return "Find a place to sleep.";
        }

    }
}
