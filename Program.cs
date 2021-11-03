using System;
using System.Text.RegularExpressions;


namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a name: ");
            string input = Console.ReadLine();
            if (ValidateName(input))
            {
                Console.WriteLine("Name is valid!");
            } 
            else
            {
                Console.WriteLine("Name is not valid!");
            }

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
    }
}
