using System.Collections.Generic;

namespace _09_oldest_family_member
{
    class Family
    {
        private List<Person> _people = new List<Person>();

        //public Family(List<Person> people)
        //{
        //    _people = people;
        //}

        public Family()
        {

        }

        public List<Person> GetPeople() { return _people; }

        public void SetPeople(List<Person> people) { _people = people; }

        public void AddMember(Person person)
        {
            List<Person> tmp = GetPeople();

            tmp.Add(person);
        }

        public Person GetOldestMember()
        {
            int index = 0;

            int biggest = int.MinValue;

            foreach (var person in GetPeople())
            {
                if (biggest < person.GetAge())
                {
                    biggest = person.GetAge();

                    index = GetPeople().IndexOf(person);
                }
            }

            return GetPeople()[index];
        }
    }
}
