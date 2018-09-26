using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory1 = new Factory();
            factory1.Getarea("Circle");
            Factory factory2 = new Factory();
            factory2.Getarea("Triangle");
            Factory factory3 = new Factory();
            factory3.Getarea("Square");
            Factory factory4 = new Factory();
            factory4.Getarea("Rectangle");

        }
    }
}
