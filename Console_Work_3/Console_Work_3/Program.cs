using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n Sayisini Giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i+1+".Kelimeyi Giriniz: ");
                array[i] = Console.ReadLine();
            }
            for (int j = array.Length-1; j >=0; j--)
            {
                Console.Write(array[j]+" ");
            }

            Console.ReadKey();

        }
    }
}
