using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.People;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int n = 0;
            Random r = new Random();

            Console.WriteLine("insert number");
            number = Convert.ToInt32(Console.ReadLine());

            List<Person> people = new List<Person>();

            for(int i = 0; i < number; i++)
            {
                people.Add(new Person(r.Next(1, 101), n));
                n++;
            }

            var sortedQuery = people.OrderBy(x => x._name);
            var sortedList = sortedQuery.ToList();

            for(int i = 0; i < number; i++)
            {
                if(sortedList[i]._age > 30)
                {
                    sortedList[i].PrintPerson();
                }
            }

            Console.ReadLine();
        }
    }
}
