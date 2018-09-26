using System;
using System.Collections.Generic;
using System.Text;

namespace homework3
{
    public class Factory
    {
        public double height;
        public double r;
        public double width;
        public virtual void Showarea()
        {
        }
        public Factory Getarea(String type)
        {
            Factory factory;
            if (type.Equals("Circle"))
            {
                factory = new Circle();
                Console.WriteLine("Please Input r");
                factory.r = double.Parse(Console.ReadLine());
            }
            else if (type.Equals("Square"))
            {
                factory = new Square();
                Console.WriteLine("Please Input height");
                factory.height = double.Parse(Console.ReadLine());
            }
            else if (type.Equals("Rectangle"))
            {
                factory = new Rectangle();
                Console.WriteLine("Please Input height");
                factory.height = double.Parse(Console.ReadLine());
                Console.WriteLine("Please Input width");
                factory.width = double.Parse(Console.ReadLine());
            }
            else if (type.Equals("Triangle"))
            {
                factory = new Triangle();
                Console.WriteLine("Please Input height");
                factory.height = double.Parse(Console.ReadLine());
                Console.WriteLine("Please Input width");
                factory.width = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Please Input Right Type!");
                return null;
            }
            factory.Showarea();
            return factory;
        }


        
    }
}
