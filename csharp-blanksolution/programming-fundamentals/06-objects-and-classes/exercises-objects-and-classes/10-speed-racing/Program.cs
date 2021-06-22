using System;

namespace _10_speed_racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfCars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfCars; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                string model = data[0];
                double fuel = double.Parse(data[1]);
                double consumption = double.Parse(data[2]);
                double distance = double.Parse(data[3]);

                var car = new Car();
                car.SetModel(model);
                car.SetFuel(fuel);
                car.SetConsumption(consumption);
                car.SetDistance(distance);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {


                command = Console.ReadLine();
            }
        }
    }

    class Car
    {
        private string _model;
        private double _fuel;
        private double _consumption;
        private double _distance;

        public Car(string model, double fuel, double consumption, double distance)
        {
            _model = model;
            _fuel = fuel;
            _consumption = consumption;
            _distance = distance;
        }

        public Car()
        {

        }

        public string GetModel() { return _model; }

        public double GetFuel() { return _fuel; }

        public double GetConsumption() { return _consumption; }

        public double GetDistance() { return _distance; }

        public void SetModel(string model) { _model = model; }

        public void SetFuel(double fuel) { _fuel = fuel; }

        public void SetConsumption(double consumption) { _consumption = consumption; }

        public void SetDistance(double distance) { _distance = distance; }

        public bool isPossibleDistance(string model, double distance)
        {

        }
    }
}
