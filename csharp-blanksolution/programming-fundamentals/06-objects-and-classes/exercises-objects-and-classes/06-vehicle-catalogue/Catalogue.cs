using System;
using System.Collections.Generic;
using System.Text;

namespace _06_vehicle_catalogue
{
    class Catalogue
    {
        public List<Vehicle> Vehicles { get; set; }

        public Catalogue(List<Vehicle> v1)
        {
            this.Vehicles = v1;
        }
    }
}
