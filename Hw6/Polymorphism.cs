
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6
{
    //Main abstract class
    abstract class User
    {
        protected string name;
        public abstract void IntroduceSelf();
       
    }

    //Derived Student class

    class Student : User
    {
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override void IntroduceSelf()
        {
            Console.WriteLine("Hi! My name is " + name + ". I'm " + age + " years old.");
        }

    }

    //Derived Teacher class
    class Teacher : User
    {
        private string subject;
        public Teacher(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void IntroduceSelf()
        {
            Console.WriteLine("Hello! My name is " + name + ". I will be your " + subject + " teacher.");
        }

    }
}
