using System;
using System.Collections.Generic;

namespace _07_store_boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<object> objects = new List<object>();

            while (input != "end")
            {
                string[] data = input.Split(' ');

                Item item = new Item(data[1], double.Parse(data[3]));

                double boxPrice = item.Price * int.Parse(data[2]);

                Box box = new Box(int.Parse(data[0]), item, int.Parse(data[2]), boxPrice);

                objects.Add(box);

                input = Console.ReadLine();
            }

            List<double> prices = new List<double>();

            foreach (Box box in objects)
            {
                prices.Add(box.Price);
            }

            List<double> orderedPrices = new List<double>();

            int index = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                double biggest = prices[i];

                for (int k = 0; k < prices.Count; k++)
                {
                    if (biggest <= prices[k])
                    {
                        biggest = prices[k];

                        index = k;
                    }
                }

                prices.RemoveAt(index);

                orderedPrices.Add(biggest);

                i = -1;
            }

            List<object> result = new List<object>();

            for (int i = 0; i < orderedPrices.Count; i++)
            {
                foreach (Box box in objects)
                {
                    if (orderedPrices[i] == box.Price)
                    {
                        result.Add(box);

                        break;
                    }
                }
            }

            foreach (Box box in result)
            {
                Console.WriteLine(box.SerialNumber);

                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");

                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }
    }
}
