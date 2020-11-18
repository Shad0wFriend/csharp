using System;
using System.Collections.Generic;
using System.Text;

namespace _07_store_boxes
{
    class Box
    {
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public Box(int v1, Item v2, int v3, double v4)
        {
            this.SerialNumber = v1;
            this.Item = v2;
            this.Quantity = v3;
            this.Price = v4;
        }
    }
}
