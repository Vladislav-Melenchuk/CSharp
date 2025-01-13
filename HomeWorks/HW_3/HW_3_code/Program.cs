using System;

namespace Properties
{
    static class Input
    {
        static int number;

        public static int Number()
        {
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Нужно было ввести число, а не строку!");
                    continue;
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Слишком большое число!");
                    continue;
                }
                break;
            }
            return number;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int x = Input.Number();

            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                for (int k = 0; k < i; k++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");

               
                for (int k = 0; k < i; k++)
                {
                    Console.Write("  ");
                }
            }
        }
    }
}
