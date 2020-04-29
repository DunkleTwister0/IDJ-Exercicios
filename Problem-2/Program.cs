using System;
using System.Reflection;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = new Person();
            Person two = new Person(10);
            Person three = new Person("Pesho", 20);

            one.PrintPerson();
            two.PrintPerson();
            three.PrintPerson();
        }

        public class Person
        {
            public string name;
            public int age;

            public Person()
            {
                this.name = "No name";
                this.age = 1;
            }

            public Person(int n)
            {
                this.name = "No name";
                this.age = n;
            }

            public Person(string n, int a)
            {
                this.name = n;
                this.age = a;
            }

            public void PrintPerson()
            {
                Console.WriteLine("{0}, {1}", name, age);
            }
        }
    }
}
