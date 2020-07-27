using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first no");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no"); 
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Result:" + c);
            Console.ReadLine();
           
        }
    }
}
