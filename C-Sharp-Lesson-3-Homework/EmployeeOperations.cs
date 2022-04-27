using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_3_Homework
{
    public class EmployeeOperations : IEmployeeOperations
    {
        public double GetSalary(int numberOfDays, double salaryRate)
        {
            return numberOfDays * 8 * salaryRate;
        }
    }
}
