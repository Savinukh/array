using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива:\t");
            int elementCount = int.Parse(Console.ReadLine());
            int[] nombers = new int[elementCount];
            Console.WriteLine("Одномерный массив в строку");
            for (int i = 0; i < nombers.Length; i++)
            {
               Console.Write("\nВведите элемент массива под индексом {0}:\t", i+1);
                nombers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(i);
            }
            
            int[] numbers = new int[10];
            Console.WriteLine("Одномерный массив в столбец");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\nВведите элемент массива под индексом {0}:\t", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.WriteLine("Одномерный массив в диагональ:");
            Console.WriteLine("Не нашел как :/");



        }
    }
}
