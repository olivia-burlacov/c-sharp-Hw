using System;

namespace Hw4_part2
{
    class Worker
    {
        public string name;
        public int age;
        public int salary;

        public static int Sum(int item1, int item2)
        {
            return item1 + item2; 
        }

        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.name = "John";
            worker.age = 25;
            worker.salary = 1000;

            Worker worker1 = new Worker();
            worker1.name = "Sam";
            worker1.age = 26;
            worker1.salary = 2000;

            Console.WriteLine("Summ of salaries is: " + Sum(worker.salary, worker1.salary));
            Console.WriteLine("Summ of age is: " + Sum(worker.age, worker1.age));

            Worker2 worker0 = new Worker2();
            worker0.SetName("John");
            worker0.SetAge(25);
            worker0.SetSalary(1000);

            Worker2 worker2 = new Worker2();
            worker2.SetName("Sam");
            worker2.SetAge(26);
            worker2.SetSalary(2000);

            Worker2 worker3 = new Worker2();
            worker3.SetName("Sam");
            worker3.SetAge(260);
            worker3.SetSalary(4000);

            Console.WriteLine("Summ of salaries is: " + Sum(worker0.GetSalary(), worker2.GetSalary()));
            Console.WriteLine("Summ of age is: " + Sum(worker0.GetAge(), worker2.GetAge()));
        }
    }
     class Worker2
     {
        private string name;
        private int age;
        private int salary;

        //Name methods
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        //Age methods
        public void SetAge(int age)
        {
            if (CheckAge(age) == true) { this.age = age; }
            else { Console.WriteLine("Age should be between 1 and 100"); }
        }
        public int GetAge()
        {
            return age;
        }

        //Salary methods
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
        public int GetSalary()
        {
            return salary;
        }

        //Private Check Age method
        private bool CheckAge(int age)
        {
            if (age>=1 && age<=100) { return true; }
            else { return false; }
            
        }
    }
}
