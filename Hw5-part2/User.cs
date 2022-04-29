using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_part2
{
    class User
    {
        protected string name;
        protected int age;

       
        public void SetName(string _name)
        {
            name = _name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge(int _age)
        {
            age = _age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
