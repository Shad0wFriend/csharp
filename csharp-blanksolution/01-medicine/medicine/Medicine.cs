using System;
using System.Collections.Generic;
using System.Text;

namespace medicine
{
    class Medicine
    {
        private string _number;
        private string _name;
        private double _price;
        private DateTime _manifactoringDate;

        public Medicine(string number, string name, double price, DateTime manifactoringDate)
        {
            _number = number;
            _name = name;
            _price = price;
            _manifactoringDate = manifactoringDate;
        }

        public string GetNumber() => _number;

        public void SetNumber(string number) => _number = ValidateNumber(number);

        public string GetName() => _name;

        public void SetName(string name) => _name = ValidateName(name);

        public double GetPrice() => _price;

        public void SetPrice(double price) => _price = ValidatePrice(price);

        public DateTime GetManifactoringDate() => _manifactoringDate;

        public void SetManifactoringDate(DateTime manifactoringDate) => _manifactoringDate = manifactoringDate;

        private string ValidateNumber(string number)
        {
            bool isValidString = true;

            while (true)
            {
                if (number.Length > 10)
                {
                    Console.WriteLine("The string contains too many symbols");

                    number = Console.ReadLine();
                }

                foreach (char symbol in number)
                {
                    if (symbol >= 48 && symbol <= 58)
                    {
                        isValidString = true;
                    }
                    else
                    {
                        isValidString = false;
                        break;
                    }
                }
                
                if (!isValidString)
                {
                    Console.WriteLine("The string contains enough symbols but they are not numbers");

                    number = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            
            return number;
        }

        private string ValidateName(string name)
        {
            bool isValidString = true;

            while (true)
            {
                if (name.Length > 30)
                {
                    Console.WriteLine("The string contains too many symbols");

                    name = Console.ReadLine();
                }

                foreach (char symbol in name)
                {
                    if ((symbol >= 97 && symbol <= 122) || (symbol >= 65 && symbol <= 90))
                    {
                        isValidString = true;
                    }
                    else
                    {
                        isValidString = false;
                        break;
                    }
                }

                if (!isValidString)
                {
                    Console.WriteLine("The string contains enough symbols but they are not letters");

                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return name;
        }

        private double ValidatePrice(double price)
        {
            return price;
        }
    }
}
