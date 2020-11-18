using System;
using System.Collections.Generic;
using System.Text;

namespace _06_vehicle_catalogue
{
    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int Horsepower { get; set; }

        public Vehicle(string v1, string v2, string v3, int v4)
        {
            this.Type = v1;
            this.Model = v2;
            this.Colour = v3;
            this.Horsepower = v4;
        }
    }
}
