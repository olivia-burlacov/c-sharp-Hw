using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_part2
{
    class WorkerInherited:User
    {
        private int salary;

        public WorkerInherited(string _name, int _age, int _salary):base()
        {
            salary = _salary;
        }

        public void SetSalary(int _salary)
        {
            salary = _salary;
        }
        public int GetSalary()
        {
            return salary;
        }
    }
}
