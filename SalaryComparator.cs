using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class SalaryComparator : IComparer<Job>
    {
        public int Compare(Job x, Job y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
