using System;

namespace _15_tribonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 3)
            {
                Console.Write(1 + " " + 1 + " " + 2 + " ");
            }

            Tribonacci(n, 0, 1, 1, 2);
        }

        public static void Tribonacci(long n, long counter, long last, long previous, long current)
        {
            if (n == 1)
            {
                Console.Write(previous);

                return;
            }
            else if (n == 2)
            {
                Console.Write(last + " " + previous);

                return;
            }
            else if (n == 3)
            {
                Console.Write(last + " " + previous + " " + current);
            }

            while (counter < n - 3)
            {
                long tmp = current;

                current = current + previous + last;

                long temp = previous;

                previous = tmp;

                last = temp;

                Console.Write(current + " ");

                counter++;
            }
        }

        //няма нужда от рекурсия, защото мисленето в while е много по-яко, ефективно, бързо, качествено :)
    }
}
