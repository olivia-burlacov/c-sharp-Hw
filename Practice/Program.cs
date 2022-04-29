using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            RollDie();
            RollDie();
        }
    
        public static void RollDie()
        {
            Random numberGenerator = new Random();
            int dieFace = numberGenerator.Next(1, 6);

            Console.WriteLine("The number on die is: " + dieFace);
        }
    }

}
