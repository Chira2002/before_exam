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
            //creating object person1
            Person person01 = new Person();
            //creating object person2
            Person person02 = new Person();

            person01.name = "Jeewaka";
            person01.age = 21;

            person02.name = "kavindu";
            person02.age = 25;

            //accessing methods
            person01.eating();

            Console.WriteLine("Name is : " + person01.name);
            Console.WriteLine("Age is : " + person01.age); 

            Console.ReadLine();

            
        
        }
    }
}
