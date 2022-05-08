using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n sayisini giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m sayisini giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + ".Sayiyi Giriniz:");
                array[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            for (int j = 0; j < n; j++)
            {
                if (array[j]==m || array[j]%m==0)
                {
                    Console.WriteLine(array[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
