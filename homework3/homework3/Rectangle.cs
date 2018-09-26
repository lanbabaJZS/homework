using System;
using System.Collections.Generic;
using System.Text;

namespace homework3
{
    class Rectangle:Factory
    {
        public override void Showarea()
        {
            double S;
            S = height * width;
            Console.WriteLine("该矩形的面积是" + S);
        }
    }
}
