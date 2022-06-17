using System;

namespace ConsoleApp_task4
{
    class Program
    {
        static void AddLastValue(int[] array)
        {
           int[] buf_array = new int[array.Length+1];
           int j = 0;
            for (int i = 0; i < buf_array.Length; i++)
            {
                if (i < array.Length)
                {
                    buf_array[j] = array[i];
                    Console.WriteLine(buf_array[j]);
                }
                else
                {
                    Console.WriteLine(buf_array[j]);
                }
                j++;
            }
        }

        static void AddFirstValue(int[] array, int value)
        {
            int[] buf_array = new int[array.Length + 1];

            for (int i = 0; i < buf_array.Length; i++)
            {
                if (i == 0)
                {
                    buf_array[i] = value;
                    Console.WriteLine(buf_array[i]);
                }
                else
                {
                    buf_array[i] = array[i-1];
                    Console.WriteLine(buf_array[i]);
                }                 
            }
        }

        static void Main()
        {
            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 4;
            }

            Console.WriteLine("Your array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\n(Task1) Your array with last added value:");
            AddLastValue(myArray);

            Console.WriteLine("\n(Task2) Your array with first added value:");
            AddFirstValue(myArray, 15);

            Console.ReadKey();
        }
    }
}
