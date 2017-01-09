using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectONE
{
    class Program
    {
        static void Main(string[] args)
        {


            int age;
            int month;



            Console.WriteLine("Welcome to the Fortune Teller program");
            Console.WriteLine("Please enter your First Name");
            string firstname = Console.ReadLine();
            Console.WriteLine(" Hello " + firstname);
            Console.WriteLine("Please enter your Last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the number of your birth month");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color? If you need to know what ROYBGIV is, type \"help\"");
            string favco = Console.ReadLine();
            if (favco.Equals("help", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("ROYGBIV means red, orange, yellow, green, blue, and indigo \n enter your favorite color");
                favco = Console.ReadLine();
            }
            else
            {
                Console.WriteLine(favco);
            }
            Console.WriteLine("How many siblings do you have? Please enter your answer as a number");
            int sibs = int.Parse(Console.ReadLine());
            Console.WriteLine(sibs);

            //part2
            int retire;
            if (age % 2 == 0)
            {
                retire = 5;
            }

            else
            {
                retire = 10;
            }
            string vachome;
            if (sibs > 3)
            {
                vachome = "Cleveland";
            }
            else if (sibs == 3)
            {
                vachome = "Portland";
            }
            else if (sibs <= 2)
            {
                vachome = "Miami";
            }
            else if (sibs == 1)
            {
                vachome = "Chicago";
            }
            else
            {
                vachome = "Detroit";

            }

            string transportation;

            if (favco.Equals("red", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Jeep";
            }

            else if (favco.Equals("orange", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Ford Mustang";
            }
            else if (favco.Equals("yellow", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Dodge Truck";
            }
            else if (favco.Equals("green", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Schwin Bicycle";
            }
            else if (favco.Equals("blue", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Tesla";
            }
            else if (favco.Equals("indigo", StringComparison.CurrentCultureIgnoreCase))
            {
                transportation = "Bugatti";
            }
            else
            {
                transportation = "Chevrolet";
            }

            float bank; 
            if (month >= 1 && month <= 4)
                 
            {
                bank = 5000f;
            }

            else if (month == 5 && month <= 8)
            {
                bank = 10000f;
            }

            else if (month == 9 && month <= 12)
            {
                bank = 20000f;
            }

            else
            {
                bank = 0f;

            }

            Console.WriteLine(firstname + lastname + " will retire in " + retire + " years with " + bank + " in the bank, a vacation home in " + vachome + " and a " + transportation ); 






        }












    }
}

