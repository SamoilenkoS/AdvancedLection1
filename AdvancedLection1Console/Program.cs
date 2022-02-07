using System;

namespace AdvancedLection1Console
{
    class Program
    {
        /// <summary>
        /// Calc max of two numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Return maximum of two numbers</returns>
        int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static void A1()
        {
            Console.WriteLine("A1 begin");
            A2();
            Console.WriteLine("A1 end");
        }

        static void A2()
        {
            Console.WriteLine("A2 begin");
            A3();
            Console.WriteLine("A2 end");
        }

        static void A3()
        {
            Console.WriteLine("A3 begin");
            Console.WriteLine("A3 end");
        }

        static void Main(string[] args)
        {
            A1();
            int[] array = new int[5];
            Random random = new Random();
            for (int i = 0; i < array.Length; Console.WriteLine(array[i - 1]))
            {
                array[i++] = random.Next(10, 100);
            }

            int value = 10;

            int[] tempArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; ++i)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = value;
        }
    }
}
