
using System;

namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | odd                                  |
          * |--------|--------------------------------------|
          * |  2     | even                                 |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            if (number>0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is even");
                } else
                {
                    Console.WriteLine(number + " is odd");
                }
            } else
            {
                Console.WriteLine(number + " the value should be greater than zero");
            }

        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that prints if number divides to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divides to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            var result = number % 4 == 0 ? " The number divides to 4" : " The number doesn't divide to 4";
            Console.WriteLine(number + result);
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that prints the number of the day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */
            
            switch (day)
            {
                case "Monday":
                    Console.WriteLine(day + ": 1");
                    break;
                case "Tuesday":
                    Console.WriteLine(day + ": 2");
                    break;
                case "Wednesday":
                    Console.WriteLine(day + ": 3");
                    break;
                case "Thursday":
                    Console.WriteLine(day + ": 4");
                    break;
                case "Friday":
                    Console.WriteLine(day + ": 5");
                    break;
                case "Saturday":
                    Console.WriteLine(day + ": 6");
                    break;
                case "Sunday":
                    Console.WriteLine(day + ": 7");
                    break;
                default:
                    Console.WriteLine(day + ": Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */

            /* METHOD I */
            var lowerCase = Char.ToLower(character);
            switch (lowerCase)
            {
                case 'a':
                    Console.WriteLine(character + ": is a vowel");
                    break;
                case 'e':
                    Console.WriteLine(character + ": is a vowel");
                    break;
                case 'i':
                    Console.WriteLine(character + ": is a vowel");
                    break;
                case 'o':
                    Console.WriteLine(character + ": is a vowel");
                    break;
                case 'u':
                    Console.WriteLine(character + ": is a vowel");
                    break;
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    Console.WriteLine(character + ": is a consonant");
                    break;
                default:
                    Console.WriteLine(character + ": not a letter");
                    break;
            }

        }

        public void CheckLetterIfVowel2(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */

            /* METHOD II */

            var lowerCase = Char.ToLower(character);
            if (lowerCase == 'a' || lowerCase == 'e' || lowerCase == 'i' || lowerCase == 'o' || lowerCase == 'u')
            {

                Console.WriteLine(character + ": is a vowel");

            }
            else if (lowerCase >= 'a' && lowerCase <= 'z')
            {
                Console.WriteLine(character + " is a consonant");
            }
            else
            {
                Console.WriteLine(character + ": not a letter");
            }


        }

            public static void Main(String[] args)
        {
         Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');
            homework.CheckLetterIfVowel('0');
            //---------------------------------------
            homework.CheckLetterIfVowel2('T');
            homework.CheckLetterIfVowel2('O');
            homework.CheckLetterIfVowel2('*');

        }
    }
}
