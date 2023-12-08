using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Wordels
    {
        public static string ConvertNumberToWords(int numbers) 

        {

            string[] SingleDigit =new string[] { " ", "One" , "Two" , "Three" , "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] DoubleDigit = new string[] {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] Tens = new string[] {" ", " ", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

            if (numbers == 0)
            {
                return "zero";
            }
         
            else if (numbers > 0 & numbers < 10)
            {
                return SingleDigit[numbers];
            }
                

            else if (numbers >= 10 & numbers < 20)
            {
                
                return DoubleDigit[numbers-10];
            }

            else if (numbers > 20 & numbers < 100) 
            {
                
                return Tens[numbers/10] + " " + SingleDigit[numbers%10];
               
            }

            /*else if (numbers>100) 
            {
                return SingleDigit[numbers/100] + " Hundred" + " " + Tens[numbers%100/10] + DoubleDigit[numbers%100%10];
            }*/
                

            return "";
        }
        
    }

}
