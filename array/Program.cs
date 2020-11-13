using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nombers = new int[10];
            Console.WriteLine("Одномерный массив в строку:");
            for (int i = 0; i < nombers.Length; i++)
            {
               Console.Write(i);
            }
            Console.ReadKey();
            int[] numbers = new int[10];
            Console.WriteLine("Одномерный массив в столбец");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.WriteLine("Одномерный массив в диагональ:");
            Console.WriteLine("Не нашел как :/");



        }
    }
}
