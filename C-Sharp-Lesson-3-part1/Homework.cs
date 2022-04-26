using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Lesson_3_part1
{
    class Homework
    {
        static void Main(string[] args)
        {
            // QUEUE CLASS
            Queue<string> names = new Queue<string>();
            names.Enqueue("John");
            names.Enqueue("Jane");
            names.Enqueue("Anna");
            names.Enqueue("Michael");
            names.Enqueue("Blake");
            names.Enqueue("Ingrid");
            names.Enqueue("David");
            names.Enqueue("Mark");

            // Check first name inserted in queue, PEEK method
            var firstName = names.Peek();
            Console.WriteLine("First name in queue: " +firstName);

            // Print all names in queue in order of insertion, GET ENUMERATOR / MOVE NEXT methods & CURRENT variable
            var queueNames = names.GetEnumerator();
            Console.WriteLine("Name list:");
            while (queueNames.MoveNext())
            {
                Console.WriteLine(queueNames.Current);
            }

            // Remove first name in queue and the following name, DEQUEUE method
            Console.WriteLine("Removing the first name: " + names.Dequeue());
            Console.WriteLine("Removing the next name: " + names.Dequeue());

            // STACK CLASS
            Stack<string> lastNames = new Stack<string>();
            lastNames.Push("Doe");
            lastNames.Push("Smith");
            lastNames.Push("Brown");
            lastNames.Push("Miller");
            lastNames.Push("Unknown");

            // Check count of inserted last names, COUNT variable
            Console.WriteLine("Number of last names: " + lastNames.Count);

            // Remove the last last name inserted (LIFO), POP method
            Console.WriteLine("Last last name in stack : " + lastNames.Pop());

            string[] inst =
            { "Insert", "a", "full", "name", "here"};
            
            // LINKED LIST CLASS
            LinkedList<string> instruction = new LinkedList<string>(inst);

            instruction.AddLast("please");

            instruction.AddFirst("Hello! ");

            // Display the new list as a sentence
            var newInstruction = instruction.GetEnumerator();
            while (newInstruction.MoveNext())
            {
                Console.Write(newInstruction.Current+" ");
            }

            // LIST CLASS
            IList<int> testList = new List<int>() { 10, 42, -10, 0, -2, 1, -9 };
            testList.Add(32);
            
            // Sort desc the elements
            var newList = testList.OrderByDescending(number => number);
            Console.WriteLine();
            Console.WriteLine("Descending: ");

            // Print elements of list in desc order
            foreach (int num in newList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Average: " + testList.Average());

            // HASH SET CLASS
            HashSet<string> hashTest = new HashSet<string>();

            hashTest.Add("Aa");
            hashTest.Add("Ab");
            hashTest.Add("Ac");
            hashTest.Add("Ad");
            hashTest.Add("Ae");
            Console.WriteLine("Elements: ");

            // Print elements of hashset & show that same values won't be added
            hashTest.Add("Aa");
            hashTest.Add("Ai");
            foreach (var newstr in hashTest)
            {
                Console.Write(newstr + " ");
            }
            
            HashSet<string> hashTest1 = new HashSet<string>();

            hashTest1.Add("Aa");
            hashTest1.Add("Bb");
            hashTest1.Add("Ac");
            hashTest1.Add("Bd");
            hashTest1.Add("Be");

            // Check if common elements exist
            Console.WriteLine();
            Console.WriteLine("Common elements: " + hashTest1.Overlaps(hashTest));

            // Sorted SET CLASS
            SortedSet<int> sortSet = new SortedSet<int>();
            sortSet.Add(8);
            sortSet.Add(2);
            sortSet.Add(1);
            sortSet.Add(9);
            sortSet.Add(5);
            
            // Add an existing value
            sortSet.Add(5);

            Console.WriteLine("Display elements: ");
            foreach (var intset in sortSet)
            {
                Console.Write(intset + " ");
            }

            SortedList<int, string> sortList = new SortedList<int, string>();
            sortList.Add(9, "apple");
            sortList.Add(1, "orange");
            sortList.Add(6, "banana");
            sortList.Add(3, "kiwi");
            sortList.Add(7, "apple");

            // Get index of key 9
            Console.WriteLine();
            var ind= sortList.IndexOfKey(9);
            Console.WriteLine("Index of Key: " + ind);

            // Print all values from list
            var listOfValues = sortList.Values;
            Console.WriteLine("Display values: ");
            foreach (var item in listOfValues)
            {
                Console.Write(item + " ");
            }

            // Print all keys from list
            var listOfKeys = sortList.Keys;
            Console.WriteLine("Display keys: ");
            foreach (var item in listOfKeys)
            {
                Console.Write(item + " ");
            }

            // Print keys+values from list (will get sorted)

            Console.WriteLine();
            Console.WriteLine("Display elements: ");
            foreach (var item in sortList)
            {
                Console.Write(item + " ");
            }
        }
    }
} 
