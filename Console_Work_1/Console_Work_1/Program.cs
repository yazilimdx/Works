using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Sayi Adetini Giriniz:");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < number; i++)
        {
            Console.Write(i + 1 + ".Sayiyi Giriniz:");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < number; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine(array[i]);
            }
        }


        Console.ReadKey();


    }
}