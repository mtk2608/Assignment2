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

    }
    
}
