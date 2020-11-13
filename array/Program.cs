using System;

namespace array
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите кол-во элементов массива:\t");
            int elementCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[elementCount];
            int[] num = numbers;
            Console.WriteLine("------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nОднмерный массив в строку:");
            Console.ResetColor();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("\nВведите элемент массива под индексом {0}:\t", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }
            Console.WriteLine("\n------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nОдномерный массив в столбец:");
            Console.ResetColor();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("\nВведите элемент массива под индексом {0}:\t", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("------------------------------------------");

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Одномерный массив в диагональ:");
            Console.ResetColor();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("\nВведите элемент массива под индексом {0}:\t", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            int n = 0;
            for (int i = 0; i < num.Length; i++)
            {
                string v = "".PadLeft(n, ' ');
                Console.WriteLine(v + num[i]);
                n++;
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nХотите попробывать еще раз? 1 - да, 0 - нет");
            int repeat = int.Parse(Console.ReadLine());
            switch (repeat)
            {
                case 1:
                    Console.Clear();
                    Main();
                    break;
                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nСпасибо, что использовали мою программу, можете поддержать этот проект денежными средствами :)");
                    Console.ResetColor();
                    break;

            }

            Console.ReadKey();



        }
    }
}