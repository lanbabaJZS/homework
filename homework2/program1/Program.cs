using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入指定数据（uint型）：");
            uint num = uint.Parse(Console.ReadLine());
            int numprime = 0;   
                if (num == 0) Console.WriteLine("该数据无素数因子");
                if (num == 1) Console.WriteLine("该数据无素数因子");
                if (num == 2) Console.WriteLine("该数据无素数因子");
                if (num > 2)
                {
                    getPrime(num);
                }
            void getPrime(uint num1)
            {
               
                for (uint i = 2; i < num1; i++)
                {
                    if (num1 % i == 0)
                    {
                        int b;
                        for (b = 2; b < i; b++)
                        {
                            if (i % b == 0) break;
                        }
                        if (b == i) numprime++;

                    }
                }
                if (numprime > 0)
                {
                    
                    Console.WriteLine("该数据的素数因子是：");
                    for (uint i = 2; i < num1; i++)
                    {
                        if (num1 % i == 0)
                        {
                            int b;
                            for ( b = 2; b < i; b++)
                            {
                                if (i % b == 0) break;
                            }
                            if (b == i) Console.WriteLine(i + " ");
                        }
                    }
                }
                if (numprime == 0) Console.WriteLine("该数据无素数因子");
            }
        }
    }

}
