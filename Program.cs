using System;
using System.Text.RegularExpressions;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Divide(1,0));  // testing DivideByZeroException
            bool playAgain = true;
            do
            {
                Console.Write("Please enter a valid name: ");
                string input = Console.ReadLine();
                if (ValidateName(input))
                {
                    Console.WriteLine("Name is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, name is not valid!");
                }
                Console.WriteLine("");

                Console.Write("Please enter a valid email: ");
                input = Console.ReadLine();
                if (ValidateEmail(input))
                {
                    Console.WriteLine("Email is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, email is not valid!");
                }
                Console.WriteLine("");

                Console.Write("Please enter a valid phone number: ");
                input = Console.ReadLine();
                if (ValidatePhoneNumber(input))
                {
                    Console.WriteLine("Phone number is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, phone number is not valid!");
                }
                Console.WriteLine("");

                Console.Write("Please enter a valid date: ");
                input = Console.ReadLine();
                if (ValidateDate(input))
                {
                    Console.WriteLine("Date is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, date is not valid!");
                }
                Console.WriteLine("");

                Console.Write("Please enter valid HTML elements: ");
                input = Console.ReadLine();
                if (ValidateHtmlElements(input))
                {
                    Console.WriteLine("HTML elements are valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, HTML elments are not valid!");
                }
                Console.WriteLine("");

                Console.Write("Play again (y/n): ");
                playAgain = PlayAgain();
            } while (playAgain == true);

            Console.WriteLine("Thanks, press any to exit.");
            Console.ReadKey();
        }

        public static bool ValidateName(string name)
        {
            string pattern = "^[A-Z][a-z]{1,29}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static bool ValidateEmail(string email)
        {
            string pattern = "^[A-Za-z]{5,30}@[A-Za-z]{5,10}.[A-Za-z]{2,3}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = "^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateDate(string date)
        {
            string pattern = "^[0-9]{2}/[0-9]{2}/[0-9]{4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateHtmlElements(string elements)
        {
            string pattern = @"^<([a-z]{1}[0-9]*)></\1>$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(elements))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool PlayAgain()
        {
            bool isValidYesNo = false;
            do
            {
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "n")
                {
                    return false;
                }
                else if (input.Trim().ToLower() == "y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Please just enter a 'y' or an 'n'.");
                }
            } while (isValidYesNo == false);
            return false;
        }

        public static double Divide(int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}