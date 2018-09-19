using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("用欸氏筛法求出的2-100中的素数：\n");
            for (int i = 2; i < 100; i++)
            {
                int b;
                for ( b = 2; b < i; b++)
                    if (i % b == 0)
                    {
                        break;
                    }
                if (b == i) Console.WriteLine(i + " ");
            }
        }
    }
}
