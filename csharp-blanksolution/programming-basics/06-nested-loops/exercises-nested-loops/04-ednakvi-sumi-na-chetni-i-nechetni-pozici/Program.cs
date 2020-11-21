using System;

namespace _04_ednakvi_sumi_na_chetni_i_nechetni_pozicii
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                string number = i.ToString();

                int counter = 1;
                int leftSum = 0;
                int rightSum = 0;

                foreach (char item in number)
                {
                    if (counter % 2 == 0)
                    {
                        leftSum += item;
                    }
                    else
                    {
                        rightSum += item;
                    }

                    counter++;
                }

                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
