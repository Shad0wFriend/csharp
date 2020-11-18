using System;
using System.Collections.Generic;
using System.Text;

namespace _08_vehicle_catalogue
{
    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public Car(string v1, string v2, int v3)
        {
            this.Brand = v1;
            this.Model = v2;
            this.HorsePower = v3;
        }
    }
}
