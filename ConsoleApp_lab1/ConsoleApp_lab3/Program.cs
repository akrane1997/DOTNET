using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab3
{
   unsafe class Program
    {
        static void Main(string[] args)
        {
            int a= 10;
            int* a_ptr = &a;

            Console.WriteLine(*a_ptr);
            
            Console.WriteLine((int)&a_ptr);

            Console.Read();

        }
    }
}
