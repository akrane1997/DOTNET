using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console app_Lab 4");

            Console.WriteLine("Enter your fav 1st Cuntry Name: ");
            string country1 = Console.ReadLine();
           
            Console.WriteLine("Enter your fav 2st Cuntry Name: ");
            string country2 = Console.ReadLine();

            Console.WriteLine("Choose any one no of below option:-" +
                "\n 1. for reverse 1st country name." +
                "\n 2. for concating two country name." +
                "\n 3. for display the length second country name." +
                "\n 4. for display the first 2 charactor of the 1st country name." +
                "\n 5. for exit.");
            int choice = int.Parse(Console.ReadLine());
            do
            {
                switch(choice)
                {
                    case 1 :
                        char[] charArray = country1.ToCharArray();
                        Array.Reverse(charArray);
                        Console.WriteLine(new string(charArray));
                        Console.ReadLine();
                        break;

                    case 2:
                        string concatString = string.Concat(country1, country2);
                        Console.WriteLine(concatString);
                        Console.ReadLine();
                        break;

                    case 3:
                        int length = country2.Length;
                        Console.WriteLine("Length of the country2 is : " + length);
                        Console.ReadLine();
                        break;

                    case 4:
                        string subString = country1.Substring(0,2);
                        Console.WriteLine(subString);
                        Console.ReadLine();
                        break;

                    case 5 :

                        return ;
                }


            }
            while (choice <= 5);

        }
    }
}
