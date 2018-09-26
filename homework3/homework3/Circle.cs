using System;
using System.Collections.Generic;
using System.Text;


namespace homework3
{
    class Circle:Factory
    {
        public override void Showarea()
        {
            double S;
            S = System.Math.PI * r * r;
            Console.WriteLine("该圆的面积是" + S);
        }
    }
}
