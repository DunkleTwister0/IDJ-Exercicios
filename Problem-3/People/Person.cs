using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem_3.People
{
    class Person
    {
        private string name;
        private int age;
        private string[] names = {"Buster", "Clyde", "Ellouise", "Finnley", "Anish", "Catherine"
        , "Ebonie", "huey", "Carly", "Bob" };

        public int _age
        {
            get
            {
                return age;
            }
        }

        public string _name
        {
            get
            {
                return name;
            }
        }

        public Person()
        {
            name = "No name";
            age = 0;
        }

        public Person(int a, int m)
        {
            name = names[m];
            age = a;
        }

        public void PrintPerson()
        {
            Console.WriteLine("{0}, {1} years old", name, age);
        }
    }
}
