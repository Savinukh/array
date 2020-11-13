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
            int[] numbers = new int[elementCount];
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nОднмерный массив в строку:");
            for (int i = 0; i < nombers.Length; i++)
            {
               Console.Write("\nВведите элемент массива под индексом {0}:\t", i+1);
                nombers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < nombers.Length; i++)
            {
                Console.Write(nombers[i]);
            }
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("\nОдномерный массив в столбец:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\nВведите элемент массива под индексом {0}:\t", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
                            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("------------------------------------------");

            Console.ReadKey();
            Console.WriteLine("Одномерный массив в диагональ:");
            Console.WriteLine("Не нашел как сделать :/");
            Console.WriteLine("------------------------------------------");
            Console.ReadKey();



        }
    }
}
