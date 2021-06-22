namespace _09_oldest_family_member
{
    class Person
    {
        private string _name;
        private int _age;

        //public Person(string name, int age)
        //{
        //    _name = name;
        //    _age = age;
        //}

        public Person()
        {
           
        }

        public string GetName() { return _name; }

        public void SetName(string name) { _name = name; }

        public int GetAge() { return _age; }

        public void SetAge(int age) { _age = age; }
    }
}
