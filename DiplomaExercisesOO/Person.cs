using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaExercisesOO
{
    abstract class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        private string gender;

        public string GetGender()
        {
            return gender;
        }

        public virtual string GetOccupation()
        {
            return "Unemployed";
        }

        public Person(string pFirstName, string pLastName, string pGender)
        {
            firstName = pFirstName;
            switch (pGender)
            {
                case "M":
                    gender = pGender;
                    break;
                case "F":
                    gender = pGender;
                    break;
                default:
                    throw new InvalidOperationException("You have entered an incorrect gender.");
            }
            lastName = pLastName;
        }

        public Person(string pGender)
        {
            switch (pGender)
            {
                case "M":
                    firstName = "John";
                    gender = pGender;
                    break;
                case "F":
                    firstName = "Jane";
                    gender = pGender;
                    break;
                default:
                    throw new InvalidOperationException("You have entered an incorrect gender.");
            }
            lastName = "Doe";
        }

        public abstract string Work();
        
    }
}
