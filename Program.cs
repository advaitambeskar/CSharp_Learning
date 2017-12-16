using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int randomNumber = 5;
            Console.WriteLine("The Random Number is {0}", randomNumber);
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}. It is a pleasure to meet you.", yourName);
            int yourAge;
            Console.WriteLine("Could I please ask you for your age?");
            yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oh! So you are {0} years old then!", yourAge);
            //The above code is just random examples of input and output
            /*
             * This infact is an example of just how commenting works.
             */
            var randomInformation = true;
            //Console.WriteLine(randomInformation);
            const double Pi = 3.14;
            //Console.WriteLine("The value of Pi is {0}", Pi);
            if (Pi * yourAge > 3.1 * 21)
            {
                Console.WriteLine("You are old enough to drink!");
                Console.WriteLine("So, how would you like to celebrate? Wait... before that.. I need to know \nHow much marks did you get?");
                double marks = Convert.ToDouble(Console.ReadLine());
                if (marks > 50)
                {
                    Console.Write("Congrats!");
                    if (marks == 100)
                    {
                        Console.Write(" You have a perfect score!\n");
                    }
                    else if (marks > 90)
                    {
                        Console.Write(" That is a high score! Wow!");
                    }
                    Console.WriteLine("Here is your drink!");
                }
                else
                {
                    Console.WriteLine("No Drinks for you!");
                }
            }
            else
            {
                Console.WriteLine("UNDERAGE!! FELONY!!");
            }
            Console.WriteLine("\nLet us try the Switch Case now!");
            int num = 10;
            switch (num)
            {
                case 1:
                    Console.WriteLine("The num is {0}", num);
                    break;
                case 10:
                    Console.WriteLine("The num is {0}", num);
                    break;
                case 3:
                    Console.WriteLine("The num is {0}", num);
                    break;
                default:
                    Console.WriteLine("Your num is not found!");
                    break;
            }

            Console.WriteLine("Now! While Loop!");
            num = 1;
            while (num < 6)
            {
                Console.WriteLine("{0} now!", num);
                num++;
            }

            Console.WriteLine("\nIt is now time for loop! :P\n");
            num = 1;
            int sum = 0;
            for (num = 0; num < 100; num++)
            {
                sum = sum + num;
            }
            Console.WriteLine("The Sum is {0}", sum);
            Console.WriteLine("\n\nNow it is time for some do-while!\n");
            num = 1;
            do
            {
                Console.WriteLine("{0}", num);
                num = num + 2;
            } while (num < 10);

        }
    }
}
