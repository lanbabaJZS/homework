using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double num1, num2;
            Console.Write("Please input num1:");
            s = Console.ReadLine();
            num1 = Double.Parse(s);
            Console.Write("Please input num2:");
            s = Console.ReadLine();
            num2 = Double.Parse(s);
            Console.WriteLine("The multiplication of num1 and num2 is:" + (num1 * num2));
        }
    }
}
