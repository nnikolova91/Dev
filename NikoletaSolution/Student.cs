using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikoletaSolution
{
    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double Average => Grades.Average();
    }
}
