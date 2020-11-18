using System;
using System.Linq;

namespace _07_max_sequence_of_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            int number = 0;
            int sequence = 0;

            bool isCapsuled = true;

            for (int i = 0; i < numbers.Length; i += counter)
            {
                counter = 0;

                for (int k = i; k < numbers.Length; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        counter++;
                    }
                    else
                    {
                        if (isCapsuled)
                        {
                            sequence = counter;
                            number = numbers[i];
                            isCapsuled = false;
                        }

                        break;
                    }
                }

                if (sequence >= counter)
                {

                }
                else
                {
                    sequence = counter;
                    number = numbers[i];
                }

                if (counter == 0)
                {
                    counter = 1;
                }
            }

            for (int i = 0; i < sequence; i++)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
