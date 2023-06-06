using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //function to sum two numbers
        //function takes two input parameters
        static void SumTwoNumber(int num1, int num2) 
        {
            //use the keyword "sum" to save the value
            int sum = num1 + num2;
            //print to screen
            Console.WriteLine("Sum :" + sum);  
        }
        
        static void Main(string[] args)
        {
            SumTwoNumber(1, 2);
        }
    }
}
