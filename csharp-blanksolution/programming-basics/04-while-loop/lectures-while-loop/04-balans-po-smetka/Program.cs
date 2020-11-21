using System;

namespace _04_balans_po_smetka
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInstallments = int.Parse(Console.ReadLine());
            double account = 0;
            int a = 0;

            while (true)
            {
                if (a == numberOfInstallments)
                {
                    Console.WriteLine($"Total: {account:F2}");
                    break;
                }
                else
                {
                    a++;
                }

                double installment = double.Parse(Console.ReadLine());

                if (installment > 0)
                {
                    Console.WriteLine($"Increase: {installment:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {account:F2}");
                    break;
                }

                account += installment;
            }
        }
    }
}
