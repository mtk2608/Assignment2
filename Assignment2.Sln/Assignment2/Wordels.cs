using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            string[] DoubleDigit = new string[] {"T", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
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
                
                if (numbers % 10 == 0) 
                {
                    return Tens[numbers / 10];
                }
                else (numbers>20 & numbers < 99)
                {
                    return Tens[numbers / 10] + " " + SingleDigit[numbers % 10];
                }
               
            }

            else if (numbers>=100 & numbers<999) 
            {
                if (numbers % 100 == 0)
                {
                    return SingleDigit[numbers / 100] + " Hundred ";
                }
                else if (numbers % 100 > 0 & numbers % 100 < 10)
                {
                    return SingleDigit[numbers / 100] + " Hundred " + " " + SingleDigit[numbers % 10];
                }

                else if (numbers%100>=10 & numbers%100<20)
                { 
                    return SingleDigit[numbers / 100] + " Hundred " + " " + DoubleDigit[numbers%100-10];
                }

                else if (numbers%100>=20 & numbers % 100 < 99) 
                {
                    return SingleDigit[numbers / 100] + " Hundred " + Tens[numbers%100 / 10] + " " + SingleDigit[numbers % 10];
                }

            }

            else if (numbers>=1000 & numbers<9999) 
            {
                if (numbers%1000==0)
                {
                    return SingleDigit[numbers/1000] + " Thousand ";
                }
                else if (numbers % 1000 > 0 & numbers % 1000 < 10)
                {
                    return SingleDigit[numbers / 1000] + " Thousand " + SingleDigit[numbers % 10];
                }

                else if (numbers%1000>=10 & numbers % 1000 < 20)
                {
                    return SingleDigit[numbers / 1000] + " Thousand " +  DoubleDigit[numbers % 1000 - 10];
                }
                
                else if (numbers % 1000%100 >=10 & numbers % 1000%100 <=19)
                {
                    return SingleDigit[numbers / 1000] + " Thousand " + SingleDigit[numbers % 1000 / 100] + " Hundred " + DoubleDigit[numbers % 1000 % 100 - 10];
                }
                else if (numbers % 1000 >= 20 & numbers % 1000 < 99)
                {
                    return SingleDigit[numbers / 1000] + " Thousand " + Tens[numbers % 1000 / 10] + " " + SingleDigit[numbers % 10];
                }
                else if (numbers%1000>=100 & numbers%1000 <= 999)
                {
                    return SingleDigit[numbers / 1000] + " Thousand " + SingleDigit[numbers % 1000 / 100] + " Hundred " + Tens[numbers % 1000 % 100 / 10] + SingleDigit[numbers % 1000 % 100 % 10] ;
                }
                

            }
                

            return "";
        }
        
    }

}
