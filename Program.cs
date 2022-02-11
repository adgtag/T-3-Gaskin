// Alex Gaskin
// T-3 Assignment


using System;

namespace T_3_Gaskin
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter increment value
            Console.WriteLine("Please enter an increment value that's between 5 and 25 will be used to increment CAD shown in each row.");
            // use try catch logic 
            try

            {
                // input from user is converted into a variable
                string input = Console.ReadLine();
                int incrementValue = int.Parse(input);

                // define variables
                decimal usDollar = 0m;
                decimal canadaDollar = 0m;
                decimal conversationNum = 0.792367m;

                // check to see if input is between 5 and 25
                if ((incrementValue >= 5) && (incrementValue <= 25))
                {
                    // Variable input defined from user
                    Console.WriteLine("CAD increment value = 0.792367");
                    Console.WriteLine();
                    Console.WriteLine("CAD" + "    " + "$US");
                    Console.WriteLine();

                    // display text in console
                    while (canadaDollar <= 200)
                    {
                        Console.WriteLine("$" + canadaDollar.ToString() + "    $" + usDollar.ToString());
                        canadaDollar = (canadaDollar + incrementValue);
                        usDollar = decimal.Multiply(canadaDollar, conversationNum);
                    }
                }
                else
                {
                    Console.WriteLine("number entered is not between the range of 5 and 25");
                }
                }
                // try catch to handle exceptions
                catch
            {
                Console.WriteLine("input entered is not a valid number. Please try again");
            }

        }
    }
}
