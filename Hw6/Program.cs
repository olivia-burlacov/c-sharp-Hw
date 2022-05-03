using System;

namespace Hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("John", 20);
            Student s2 = new Student("Ann", 20);
            Teacher t1 = new Teacher("Malcolm", "Mathematics");
            Teacher t2 = new Teacher("Jane", "Literature");

            User[] users = { s1, s2, t1, t2 };
            
            foreach (User item in users)
            {
                item.IntroduceSelf();
                item.ContinueIntro();
            }


            //Overload implementation
            Student[] students = { s1, s2 };

            foreach (Student item in students)
            { 
                item.ContinueIntro(" years old."); 
            }
        }
    }
}
