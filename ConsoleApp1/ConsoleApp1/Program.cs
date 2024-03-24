using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for num 01: ");
            int num01=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for num 01: ");
            int num02=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total is = "+(num01+num02));
            
        }
    }
}
