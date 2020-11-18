using System;

namespace _01_train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int counter = 0;
            int number = 0;
            int sum = 0;

            int[] numbers = new int[countOfLines];

            while (counter < countOfLines)
            {
                number = int.Parse(Console.ReadLine());

                numbers[counter] = number;

                sum += numbers[counter];

                counter++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
