using System;
using System.Collections.Generic;
using System.Text;

namespace _07_store_boxes
{
    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Item(string v1, double v2)
        {
            this.Name = v1;
            this.Price = v2;
        }
    }
}
