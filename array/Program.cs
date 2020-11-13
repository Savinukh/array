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
            Console.WriteLine("------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nОдномерный массив в строку:");
            Console.ResetColor();
            for (int i = 0; i < numbers.Length; i++)
            {
               Console.Write("\nВведите элемент массива под индексом {0}:\t", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine("\n------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nОдномерный массив в столбец:");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Одномерный массив в диагональ:");
            Console.ResetColor();
            int[] num = new int[4];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("\nВведите элемент массива под индексом {0}:\t", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            Console.WriteLine(num[0]);
            Console.Write(" ");
            Console.WriteLine(num[1]);
            Console.Write("  ");
            Console.WriteLine(num[2]);
            Console.Write("   ");
            Console.WriteLine(num[3]);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nХотите попробывать еще раз? 1 - да, 0 - нет");
            int repet = int.Parse(Console.ReadLine());
            switch (repet)
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
