using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_vehicle_catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalogue catalogue = new Catalogue();

            while (input != "end")
            {
                string[] data = input.Split('/');

                if (data[0] == "Car")
                {
                    Car car = new Car(data[1], data[2], int.Parse(data[3]));

                    catalogue.Cars.Add(car);
                }
                else if (data[0] == "Truck")
                {
                    Truck truck = new Truck(data[1], data[2], int.Parse(data[3]));

                    catalogue.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            int counter = 0;

            foreach (Car car in catalogue.Cars.OrderBy(c => c.Brand))
            {
                if (counter == 0)
                {
                    Console.WriteLine("Cars:");

                    counter++;

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

                    continue;
                }

                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            counter = 0;

            foreach (Truck truck in catalogue.Trucks.OrderBy(t => t.Brand))
            {
                if (counter == 0)
                {
                    Console.WriteLine("Trucks:");

                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

                    counter++;

                    continue;
                }

                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
