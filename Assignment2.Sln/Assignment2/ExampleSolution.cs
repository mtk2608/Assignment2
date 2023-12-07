using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ExampleSolution
    {
        //public static void Main(string[] args)
        {
            static string ConvertNumberToWords(int number)
            {
                if (number == 0)
                    return "Zero";

                if (number < 0)
                    return "Minus " + ConvertNumberToWords(Math.Abs(number));

                string words = "";

                if ((number / 1000) > 0)
                {
                    words += ConvertNumberToWords(number / 1000) + " Thousand ";
                    number %= 1000;
                }

                if ((number / 100) > 0)
                {
                    words += ConvertNumberToWords(number / 100) + " Hundred ";
                    number %= 100;
                }

                if (number > 0)
                {
                    if (words != "")
                        words += " ";

                    var unitsMap = new[]
                    {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

                    var tensMap = new[]
                    {
            "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

                    if (number < 20)
                        words += unitsMap[number];
                    else
                    {
                        words += tensMap[number / 10];
                        if ((number % 10) > 0)
                            words += "-" + unitsMap[number % 10];
                    }
                }

                return words;


            }

            int number = 149;
            string words = ConvertNumberToWords(number);
            Console.WriteLine(words); // Output: One Hundred Forty Nine

            number = 1149;
            words = ConvertNumberToWords(number);
            Console.WriteLine(words); // Output: One Thousand One Hundred Forty Nine

            number = 42;
            words = ConvertNumberToWords(number);
            Console.WriteLine(words); // Output: Forty Two

            number = 890;
            words = ConvertNumberToWords(number);
            Console.WriteLine(words); // Output: Eight Hundred Ninety//

        }
    }
