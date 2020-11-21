using System;

namespace _07_train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int judges = 0;
            int countOfPresentaions = 0;
            double grade = 0;
            double finalGrade = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {finalGrade / countOfPresentaions:F2}.");

                    break;
                }

                if (counter == 0)
                {
                    judges = int.Parse(input);

                    counter++;

                    continue;
                }

                string presentation = input;

                while (true)
                {
                    if (counter == judges + 1)
                    {
                        counter = 1;
                        break;
                    }

                    grade += double.Parse(Console.ReadLine());

                    counter++;
                }

                double presentGrade = grade / judges;

                finalGrade += presentGrade;

                grade = 0;

                countOfPresentaions++;

                Console.WriteLine($"{presentation} - {presentGrade:F2}.");
            }
        }
    }
}
