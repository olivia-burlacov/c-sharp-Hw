using System;

namespace Hw5_part2
{
    class Worker
    {
        private string name;
        private int age;
        private int salary;

        public Worker(string _name, int _age, int _salary)
        {
            name = _name;
            age = _age;
            salary = _salary;
        }
        static void Main(string[] args)
        {
            Worker worker = new Worker("John", 25, 1000);
            Console.WriteLine("Age is: " + worker.GetName());
            Console.WriteLine("Salary is: " + worker.GetSalary());

            WorkerInherited worker1 = new WorkerInherited("Ivan", 25, 1000);
            WorkerInherited worker2 = new WorkerInherited("Vasya", 26, 2000);
            Console.WriteLine("The sum of salaries is: " + (worker1.GetSalary() + worker2.GetSalary()));

            Student student1 = new Student("Jane", 20, 500, "Mathematics");
            student1.Display();

        }

        public string GetName()
        {
            return name;
        }
        public int GetSalary()
        {
            return salary;
        }
    }
}
