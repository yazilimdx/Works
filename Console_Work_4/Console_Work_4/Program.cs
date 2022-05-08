using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cumle Yaziniz: ");
            string str = Console.ReadLine();
            Console.WriteLine(HarfSayisi(str));
            Console.WriteLine(KelimeSayisi(str));

            Console.ReadKey();
        }


        static int HarfSayisi(string str)
        {
            char[] array = str.ToCharArray();
            int sayac = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==' ')
                {
                    sayac++;
                }
            }

            return str.Length - sayac;
        }

        static int KelimeSayisi(string str)
        {
            string[] array = str.Split(' ');

           
            return array.Length;
        }
    }
}
