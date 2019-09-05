using System;

namespace OOP
{
    class Person
    {
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0}", age);
        }
    }

    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }

    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool check = false;

            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (check)
                Console.ReadLine();
        }
    }
}
