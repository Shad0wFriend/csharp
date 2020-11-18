using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_anonymous_threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "merge")
                {
                    int start = int.Parse(commands[1]);

                    if (start < 0)
                    {
                        start = 0;
                    }

                    int end = int.Parse(commands[2]);

                    Merge(data, start, end);
                }
                else if (commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);

                    int partitions = int.Parse(commands[2]);

                    Divide(data, index, partitions);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', data));
        }

        public static void Merge(List<string> data, int start, int end)
        {
            if (start >= data.Count)
            {
                return;
            }

            int position = start + 1;

            for (int i = start + 1; i <= end; i++)
            {
                if (position >= data.Count)
                {
                    break;
                }

                data[start] += data[start + 1];

                data.RemoveAt(position);
            }
        }

        public static void Divide(List<string> data, int index, int partitions)
        {
            int lengthOfString = data[index].Length;

            int lengthOfPartitions = lengthOfString / partitions;

            int lastPartition = 0;

            if (lengthOfString % partitions != 0)
            {
                lastPartition = lengthOfString % partitions;

                if (lastPartition <= lengthOfPartitions)
                {
                    int tmp = lastPartition;

                    lastPartition = lengthOfString - ((partitions - 1) * lastPartition);

                    lengthOfPartitions = tmp;
                }
                else
                {
                    if (lastPartition + (lengthOfPartitions * (partitions - 1)) < lengthOfString)
                    {
                        lastPartition = lengthOfString - (lengthOfPartitions * (partitions - 1));
                    }
                }
            }

            int counter = index;

            string substring = "";

            int position = 0;

            for (int i = 0; i < partitions; i++)
            {
                if (position >= data[counter].Length)
                {
                    break;
                }

                if (i == partitions - 1)
                {
                    if (lastPartition > 0)
                    {
                        for (int k = 0; k < lastPartition; k++)
                        {
                            substring += data[counter][position];

                            position++;
                        }

                        lengthOfPartitions = 0;
                    }
                }

                for (int k = 0; k < lengthOfPartitions; k++)
                {
                    substring += data[counter][position];

                    position++;
                }

                data.Insert(counter, substring);

                counter++;

                substring = "";

                if (i == partitions - 1)
                {
                    data.RemoveAt(counter);
                }
            }
        }
    }
}
