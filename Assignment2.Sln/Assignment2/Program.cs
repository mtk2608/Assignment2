using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    internal class Program
    {
        public static void Main(string[] args) 
        
        
        {
            Console.WriteLine("Enter Up To 4 Digits");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Wordels.ConvertNumberToWords(input));
        }

        


        /*static string ConvertNumberToWords(int number)
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

                //Console.WriteLine(words);
            }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Up To 4 Digits");
            int input = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(ConvertNumberToWords(input));
            
        }*/

    }
    
}
