using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5
{
   static class WildAnimalExtension
    {

        public static void MakeNoise(this Animal animal)
        {
            if (animal.GetType() == "wolf")
            {
                Console.WriteLine("what does the " + animal.GetType() + " say: " + "ARH - WOOOOOOOOOOOOOOOOOOOO");
            }
            else if (animal.GetType() == "fox")
            {
                Console.WriteLine("what does the " + animal.GetType() + " say: " + "Ring-ding-ding-ding-dingeringeding!");
            }


        }
    }
}
