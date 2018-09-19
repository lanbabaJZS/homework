using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这里有一组数据 1 4 7 8 9 6 4");
            int[] array = { 1, 4, 7, 8, 9, 6, 4 };
            getmax(array);
            getmin(array);
            getsum(array);
            getaverage(array);

        }
        static void getmax(int [] array1)
        {
            int max = array1[0];
            for (int i = 0; i <array1.Length; i++)
            {
                
                if (max <= array1[i]) max = array1[i];
            }
            Console.WriteLine("最大值是：");
            Console.WriteLine(max);
        }

        static void getmin(int[] array1)
        {
             int min = array1[0];
            for (int i = 0; i <array1.Length; i++)
            {
            
                if (min >= array1[i]) min = array1[i];
            }
            Console.WriteLine("最小值是：");
            Console.WriteLine(min);
        }
        
        static void getsum(int[] array1)
        {
            int sum = 0;
            foreach (int i in array1)
            {
                sum += i;
            }
            Console.WriteLine("和是");
            Console.WriteLine(sum);
        }
        static void getaverage(int[] array1)
        {
            int sum = 0;
            foreach (int i in array1)
            {
                sum += i;
            }
            double average = sum / 7.0;
            Console.WriteLine("平均值是：");
            Console.WriteLine(average);
        }
  
        
    }
}
