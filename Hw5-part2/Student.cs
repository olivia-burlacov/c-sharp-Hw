using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_part2
{
    class Student : User
    {
        private int scholarship;
        private string course;

        public Student(string _name, int _age, int _scholarship, string _course) : base()
        {
            scholarship = _scholarship;
            course = _course;
        }


        public void SetScholarship(int _scholarship)
        {
            scholarship = _scholarship;
        }
        public int GetScholarship()
        {
            return scholarship;
        }

        public void SetCourse(string _course)
        {
            course = _course;
        }
        public string GetCourse()
        {
            return course;
        }

        public void Display()
        {
            Console.WriteLine("The scholarship is " + GetScholarship() + " and the course is " + GetCourse());
        }
    }
}
