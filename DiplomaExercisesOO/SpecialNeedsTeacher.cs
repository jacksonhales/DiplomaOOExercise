using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaExercisesOO
{
    class SpecialNeedsTeacher : Teacher
    {

        public SpecialNeedsTeacher(string pFirstName, string pLastName, string pGender, int pStaffID) : base(pFirstName, pLastName, pGender, pStaffID)
        {
            teachBehaviour = new TeachSpecialNeeds();
        }

    }
}
