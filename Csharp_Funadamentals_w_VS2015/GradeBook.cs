using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Funadamentals_w_VS2015
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;

        




    }
}
