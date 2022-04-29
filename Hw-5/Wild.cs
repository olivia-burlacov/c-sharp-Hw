using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5
{
    public class Wild : Animal
    {
        private string habitat;
        
        public Wild(string _type, string _species, int _noOfLegs, string _food, string _habitat) : base(_type, _species, _noOfLegs, _food)
        {
            habitat = _habitat;
        }
    }
}
