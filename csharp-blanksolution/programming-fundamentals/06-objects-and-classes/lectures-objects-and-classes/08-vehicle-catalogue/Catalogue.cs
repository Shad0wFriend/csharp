using System;
using System.Collections.Generic;
using System.Text;

namespace _08_vehicle_catalogue
{
    class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();

            Trucks = new List<Truck>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
}
