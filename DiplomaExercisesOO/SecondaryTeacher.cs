using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaExercisesOO
{
    class SecondaryTeacher : Teacher
    {

        public override string GetOccupation()
        {
            return "Teach secondary school";
        }

        public SecondaryTeacher(string pFirstName, string pLastName, string pGender, int pStaffID) : base(pFirstName, pLastName, pGender, pStaffID)
        {
            teachBehaviour = new TeachHighSchool();
        }

    }
}
