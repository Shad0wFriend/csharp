using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_drum_set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> tmp = new List<int>();

            tmp.AddRange(drums);

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int damage = int.Parse(input);

                for (int i = 0; i < tmp.Count; i++)
                {
                    tmp[i] -= damage;

                    if (tmp[i] <= 0)
                    {
                        if (savings - (drums[i] * 3) >= 0)
                        {
                            savings -= drums[i] * 3;

                            tmp[i] = drums[i];
                        }
                    }
                }

                for (int i = 0; i < tmp.Count; i++)
                {
                    if (tmp[i] <= 0)
                    {
                        tmp.RemoveAt(i);

                        drums.RemoveAt(i);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', tmp));

            Console.WriteLine($"Gabsy has {savings:F2}lv.");

            //малките неща затова са млаки, за да се уважават, разделят на процедурни парчета от алгоритмичен код :)
        }
    }
}
