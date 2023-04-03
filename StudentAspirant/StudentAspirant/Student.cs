using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAspirant
{
    internal class Student:IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Group { get; set; }
        public int AvgMark { get; set; }
        public int ScholarShip { get;set; }
        public Student(string FirstName,string LastName,int Group, int AvgMark)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Group = Group;
            this.AvgMark = AvgMark;
        }
        public void GetScholarShip() {
            if (AvgMark == 5)
            {
                ScholarShip = 2000;
            }
            else
            {
                ScholarShip = 0;
            }
        }
    }
}
