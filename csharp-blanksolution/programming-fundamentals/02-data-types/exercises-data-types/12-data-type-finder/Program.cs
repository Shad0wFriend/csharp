using System;

namespace _12_data_type_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool intTryParseIsSuccess = int.TryParse(input, out int intValue);
                bool doubleTryParseIsSuccess = double.TryParse(input, out double doubleValue);
                bool boolTryParseIsSuccess = bool.TryParse(input, out bool boolValue);
                bool charTryParseIsSuccess = char.TryParse(input, out char charValue);

                if (intTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (doubleTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (boolTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (charTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
