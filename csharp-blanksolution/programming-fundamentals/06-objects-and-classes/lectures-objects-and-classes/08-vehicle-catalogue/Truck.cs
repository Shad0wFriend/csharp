using System;
using System.Collections.Generic;
using System.Text;

namespace _08_vehicle_catalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

        public Truck(string v1, string v2, int v3)
        {
            this.Brand = v1;
            this.Model = v2;
            this.Weight = v3;
        }
    }
}
