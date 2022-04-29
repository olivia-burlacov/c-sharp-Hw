using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5
{
    public class Domestic : Animal
    {
        private string loyalty;

        public Domestic(string _type, string _species, int _noOfLegs, string _food, string _loyalty):base(_type, _species, _noOfLegs, _food)
        {
            loyalty = _loyalty;
        }
    }
}
