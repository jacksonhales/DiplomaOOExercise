using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaExercisesOO
{
   
    class Student : Person
    {
        private int studentID;

        // This constructor will call Person.Person(string, string, string)
        public Student (string pFirstName, string pLastName, string pGender, int pStudentID) : base (pFirstName, pLastName, pGender)
        {
            studentID = pStudentID;
        }

        public override string Work()
        {
            return "Study, Drink Coffee, Party, Sleep, Repeat.";
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

    }


}
