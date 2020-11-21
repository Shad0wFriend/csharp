using System;

namespace _05_ednakvi_sumi_na_levi_i_desni_pozicii
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
                int leftPositionSum = 0;
                int rightPositionSum = 0;
                int middleNumber = 0;

                foreach (char item in number)
                {
                    switch (counter)
                    {
                        case 1: leftPositionSum += item; break;
                        case 2: leftPositionSum += item; break;
                        case 3: middleNumber = int.Parse(item.ToString()); break;
                        case 4: rightPositionSum += item; break;
                        case 5: rightPositionSum += item; break;
                    }

                    counter++;
                }

                if (leftPositionSum == rightPositionSum)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    int smaller = Math.Min(leftPositionSum, rightPositionSum);
                    int bigger = Math.Max(leftPositionSum, rightPositionSum);

                    smaller += middleNumber;

                    if (smaller == bigger)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
