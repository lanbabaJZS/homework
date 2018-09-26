using System;
using System.Collections.Generic;
using System.Text;

namespace homework3
{
    class Square:Factory
    {
        public override void Showarea()
        {
            double S;
            S = height * height;
            Console.WriteLine("该方形的面积是" + S);
        }
    }
}
