using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAspirant
{
    internal interface IStudent
    {
        public int AvgMark { get; set; }
        public int ScholarShip { get; set; }
        public void GetScholarShip();
    }
}
