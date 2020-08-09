using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to our first Console app:");
                string firstName, LastName, department;
                Console.WriteLine("Enter your First Name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name:");
                LastName = Console.ReadLine();
                Console.WriteLine("Enter your Department Name:");
                department = Console.ReadLine();
                Console.WriteLine("Welcome Mr/Mrs " + firstName + " " + LastName + ",Your from " + department + " department.");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
}
