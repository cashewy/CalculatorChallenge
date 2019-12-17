using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers seperated by , : ex: 2,3 ");


            var userInput = Console.ReadLine();

            var stringProcessor = new StringProcessor8();

            Console.WriteLine("Result:" + stringProcessor.getSum(userInput));

        }
    }
}
