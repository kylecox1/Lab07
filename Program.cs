using System;
using System.Text.RegularExpressions;


namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Thanks, press any to exit.");
            Console.ReadKey();
        }


        public static bool ValidateName()
        {
            string pattern = "^[A-Z][a-z]{1,29}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(pattern))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
