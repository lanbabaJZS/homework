using System;
using System.Collections.Generic;
using System.Text;

namespace homework3
{
    class Triangle:Factory
    {
        public override void Showarea()
        {
            double S;
            S = (height * width)/2;
            Console.WriteLine("该三角形的面积是" + S);
        }
    }
}
