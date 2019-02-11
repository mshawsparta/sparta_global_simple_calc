using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        static void Main()
        {
            //
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The sum of {0} and {1} is: ", num1, num2, Sum(num1, num2 ) );
            Console.WriteLine(Sum(num1, num2));
            Console.Read();
            
            
            
        }
        
    }
    }

