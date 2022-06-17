using System;

namespace ConsoleApp_task3
{
    class Program
    {
        static void MyReverse(int[] array)
        {
            for (int i = (array.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void SubArray(int[] array, int index, int count)
        {
            int[] buf_array = new int[count];
            int i = 0;
            index--;            

            for (int j = 0; j < buf_array.Length; j++)
            {
                if (index < array.Length)
                {
                    buf_array[i] = array[index];
                    Console.WriteLine(buf_array[i]);
                }
                else
                {
                    buf_array[i] = 1;
                    Console.WriteLine(buf_array[i]);
                }
                index++;
                i++;
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

            Console.WriteLine("\n(Task1) Your array with the reverted values order:");
            MyReverse(myArray);

            Console.WriteLine("\n(Task2) Your new sub array:");
            SubArray(myArray, 3, 10);

            Console.ReadKey();
        }
    }
}
