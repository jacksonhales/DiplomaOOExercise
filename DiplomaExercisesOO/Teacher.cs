using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaExercisesOO
{
    class Teacher : Person
    {
        private int staffID;

        protected ITeach teachBehaviour;

        public override string GetOccupation()
        {
            return "Teacher";
        }

        public Teacher(string pFirstName, string pLastName, string pGender, int pStaffID) : base(pFirstName, pLastName, pGender)
        {
            staffID = pStaffID;
        }

        public override string Work()
        {
            return teachBehaviour.Teach();
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

    }
}
