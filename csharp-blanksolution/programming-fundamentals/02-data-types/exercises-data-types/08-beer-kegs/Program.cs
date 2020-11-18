using System;

namespace _08_beer_kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfKegs = int.Parse(Console.ReadLine());

            string biggest = "";
            string input = "";
            string model = "";

            int counter = 1;

            double r = 0;
            int h = 0;
            double volume = 0;

            double bigger = 0;

            int a = 0;

            for (int i = 1; i <= countOfKegs * 3; i++)
            {
                input = Console.ReadLine();

                switch (counter)
                {
                    case 1: model = input; break;
                    case 2: r = double.Parse(input); break;
                    case 3: h = int.Parse(input); break;
                }

                counter++;

                if (i % 3 == 0)
                {
                    volume = Math.PI * r * r * h;

                    if (a == 0)
                    {
                        biggest = model;

                        bigger = volume;

                        a++;
                    }
                    else
                    {
                        if (bigger >= volume)
                        {

                        }
                        else
                        {
                            bigger = volume;

                            biggest = model;
                        }
                    }

                    model = "";

                    counter = 1;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
