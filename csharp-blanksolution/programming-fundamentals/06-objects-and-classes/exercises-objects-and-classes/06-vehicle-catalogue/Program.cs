using System;
using System.Collections.Generic;

namespace _06_vehicle_catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> vehicles = new List<Vehicle>();

            while (input != "End")
            {
                string[] data = input.Split(' ');

                Vehicle vehicle = new Vehicle(data[0], data[1], data[2], int.Parse(data[3]));

                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            Catalogue catalogue = new Catalogue(vehicles);

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                PrintVehicle(model, catalogue);

                model = Console.ReadLine();
            }

            PrintAverageHorsepower(catalogue);
        }

        public static void PrintVehicle(string model, Catalogue catalogue)
        {
            foreach (Vehicle vehicle in catalogue.Vehicles)
            {
                if (vehicle.Model == model)
                {
                    if (vehicle.Type == "car")
                    {
                        Console.WriteLine("Type: Car");
                    }
                    else if (vehicle.Type == "truck")
                    {
                        Console.WriteLine("Type: Truck");
                    }

                    Console.WriteLine($"Model: {model}");

                    Console.WriteLine($"Color: {vehicle.Colour}");

                    Console.WriteLine($"Horsepower: {vehicle.Horsepower}");

                    break;
                }
            }
        }

        public static void PrintAverageHorsepower(Catalogue catalogue)
        {
            double countOfCars = 0;

            double carsHp = 0;

            double countOfTrucks = 0;

            double trucksHp = 0;

            foreach (Vehicle vehicle in catalogue.Vehicles)
            {
                if (vehicle.Type == "car")
                {
                    countOfCars++;

                    carsHp += vehicle.Horsepower;
                }
                else if (vehicle.Type == "truck")
                {
                    countOfTrucks++;

                    trucksHp += vehicle.Horsepower;
                }
            }

            double carsAverage = carsHp / countOfCars;

            double trucksAverage = trucksHp / countOfTrucks;

            if (carsAverage > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAverage:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (trucksAverage > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
