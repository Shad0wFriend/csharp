using System;

namespace _13_from_left_to_the_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int counter = 1;
            int delimeter = 0;
            int sum = 0;

            decimal leftNumber = 0M;
            decimal rightNumber = 0M;

            string leftN = "";
            string rightN = "";
            string input = "";

            while (counter <= countOfLines)
            {
                input = Console.ReadLine();

                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (input[i] == ' ')
                    {
                        delimeter++;

                        continue;
                    }

                    if (delimeter == 0)
                    {
                        leftN += input[i].ToString();
                    }
                    else
                    {
                        rightN += input[i].ToString();
                    }
                }

                delimeter = 0;

                leftNumber = decimal.Parse(leftN);
                rightNumber = decimal.Parse(rightN);

                if (leftNumber > rightNumber)
                {
                    foreach (char symbol in leftN)
                    {
                        if (symbol == '.' || symbol == '-')
                        {
                            continue;
                        }

                        sum += int.Parse(symbol.ToString());
                    }
                }
                else
                {
                    foreach (char symbol in rightN)
                    {
                        if (symbol == '.' || symbol == '-')
                        {
                            continue;
                        }

                        sum += int.Parse(symbol.ToString());
                    }
                }

                Console.WriteLine(sum);

                sum = 0;
                leftNumber = 0;
                rightNumber = 0;

                leftN = "";
                rightN = "";

                counter++;
            }
        }
    }
}
