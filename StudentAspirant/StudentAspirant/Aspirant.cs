using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAspirant
{
    internal class Aspirant : Student,IStudent
    {
        public int ScholarShip { get; set; }
        public Aspirant(string FirstName,string LastName,int Group,int AvgMark) : base(FirstName, LastName, Group, AvgMark) { }
         void IStudent.GetScholarShip()
        {
            if (AvgMark == 5)
            {
                ScholarShip = 3000;
            }
            else if (AvgMark == 4) {
                ScholarShip = 2500;
            }
            else
            {
                ScholarShip = 0;
            }
        }
    }
}
