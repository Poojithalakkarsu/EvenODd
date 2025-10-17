using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenODd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("Even Number");

            }
            else
            {
                Console.WriteLine("Odd number");
            }


        }
    }
}
