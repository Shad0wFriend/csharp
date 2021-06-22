using System;
using System.Collections.Generic;

namespace _09_oldest_family_member
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 1; i <= countOfLines; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                string name = data[0];

                int age = int.Parse(data[1]);

                var person = new Person();

                person.SetName(name);

                person.SetAge(age);

                people.Add(person);
            }

            Family family = new Family();

            family.SetPeople(people);

            var oldestMember = family.GetOldestMember();

            string output = String.Format("{0} {1}", oldestMember.GetName(), oldestMember.GetAge());

            Console.WriteLine(output);
        }
    }
}
