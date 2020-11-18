using System;
using System.Collections.Generic;
using System.Text;

namespace _07_order_by_age
{
    class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public Person(string v1, string v2, int v3)
        {
            this.Name = v1;
            this.Id = v2;
            this.Age = v3;
        }
    }
}
