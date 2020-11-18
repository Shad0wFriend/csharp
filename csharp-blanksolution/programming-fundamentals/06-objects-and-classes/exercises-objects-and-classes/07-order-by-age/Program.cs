using System;
using System.Linq;
using System.Collections.Generic;

namespace _07_order_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (input != "End")
            {
                string[] data = input.Split(' ');

                Person person = new Person(data[0], data[1], int.Parse(data[2]));

                persons.Add(person);

                input = Console.ReadLine();
            }

            foreach (Person person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
