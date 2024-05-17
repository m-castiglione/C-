using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;

namespace nthdigitofpi 
{
    class Nthdigitofpi()
    {
        const double pi = Math.PI;

        static void Main(string[] args)
        {
            Console.WriteLine(pi);
            Console.WriteLine("Enter an integer that is less than or equal to 14 for displaying PI up to that digit.: ");
            string? userInput = Console.ReadLine();
            Console.WriteLine(PrintDigit(userInput));
        }

        static double PrintDigit(string userInput) 
        {
            int? digit;
            double piToDigit;

            if (int.TryParse(userInput, out int i))
            {
                digit = Convert.ToInt32(userInput);

                if (digit <= 14) {
                    ;
                }
                else {
                    digit = 14;
                }

                piToDigit = Math.Round(pi, (int)digit);
                return piToDigit;
            }
            else 
            {
                Console.WriteLine("ERROR! Didn't input an integer");
                return 0;
            }
            
        }
    }
}