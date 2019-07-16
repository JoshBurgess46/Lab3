using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
        here:
            Console.WriteLine("What is your name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Please enter a number from 1-100. ");
            int num = int.Parse(Console.ReadLine());

            if ((num % 2 == 0)&&(num >=1)&&(num <25))
            {
                Console.WriteLine($"Hey {name}, looks like {num} is Even and less than 25. ");
            }
            else if(((num % 2==0)&&(num >=26)&&(num <=60)))
            {
                Console.WriteLine($"{name}, {num} is Even. ");
            }
            else if((num != 0)&&(num <= 59))
            {
                Console.WriteLine($"{name}, {num} is Odd. ");
            }

            else if(((num % 2 != 0)&&(num >= 61)||(num <= 100)))
            {
                Console.WriteLine($"Hey {name}, looks like {num} is odd.");
            }

            there:
            Console.WriteLine("Would you like to try again? Y or N");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "Y":
                case "y":
                    goto here;

                case "n":
                case "N":
                    Console.WriteLine("Good-Bye!");
                    break;
                default:
                    Console.WriteLine("Sorry, I do not recognize that input.");
                    goto there;
            }
            
            
            Console.ReadLine();
        }
    }
}
