using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public delegate void CalculateDelegate(int a, int b);

    public class Calculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtract: {a - b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiply: {a * b}");
        }

        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine($"Divide: {a / b}");
            else
                Console.WriteLine("Cannot divide by zero!");
        }
    }

}
