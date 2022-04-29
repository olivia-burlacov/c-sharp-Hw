using System;

namespace Hw_5
{
    public class Animal
    {
        private string type;
        private string species;
        private int noOfLegs;
        private string food;

        public Animal(string _type, string _species, int _noOfLegs, string _food)
        {
            type = _type;
            species = _species;
            noOfLegs = _noOfLegs;
            food = _food;
        }   
        public string GetType()
        {
            return type;
        }
        static void Main(string[] args)
        {
            Animal unicorn = new Animal("unicorn", "mythical", 4, "sparkles");
            Domestic dog = new Domestic("dog", "corgi", 4, "dog food", "very loyal");
            Domestic cat = new Domestic("cat", "felis catus", 4, "cat food", "no loyalty whatsoever");
            Wild wolf = new Wild("wolf", "canis lupus", 4, "meat", "forest");
            Wild fox = new Wild("fox", "vulpes", 4, "meat", "forest");
            wolf.MakeNoise();
            fox.MakeNoise();
        }
    }
}
