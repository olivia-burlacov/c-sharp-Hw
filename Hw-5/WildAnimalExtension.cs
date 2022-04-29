using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5
{
   static class WildAnimalExtension
    {

        public static void MakeNoise(this Wild wildAnimal)
        {
            if (wildAnimal.GetType() == "wolf")
            {
                Console.WriteLine("what does the " + wildAnimal.GetType() + " say: " + "ARH - WOOOOOOOOOOOOOOOOOOOO");
            }
            else if (wildAnimal.GetType() == "fox")
            {
                Console.WriteLine("what does the " + wildAnimal.GetType() + " say: " + "Ring-ding-ding-ding-dingeringeding!");
            }
        }
    }
}
