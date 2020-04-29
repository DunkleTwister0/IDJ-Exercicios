using System;
using System.Reflection;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person();
            Person gosho = new Person("Gosho", 18);
            Person stamat = new Person("Stamat", 43);

            pesho.PrintPerson();
            gosho.PrintPerson();
            stamat.PrintPerson();
        }

        public class Person
        {
            private string name;
            private int age;

            public Person()
            {
                this.name = "Pesho";
                this.age = 20;
            }

            public Person(string n, int a)
            {
                this.name = n;
                this.age = a;
            }

            public void PrintPerson()
            {
                Console.WriteLine("{0}, {1} years old.", name, age);
            }
        }
    }
}
