using System;

namespace ConsoleApp_task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter array length");
            string l = Console.ReadLine();
            int length = Convert.ToInt32(l);

            int[] myArray = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                myArray[i] = i*3;
            }

            Console.WriteLine("Your array:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            int max = myArray.Max();
            Console.WriteLine($"Max = {max}");

            int min = myArray.Min();
            Console.WriteLine($"Min = {min}");

            int sum = myArray.Sum();
            Console.WriteLine($"Sum = {sum}");

            double avarage = myArray.Average();
            Console.WriteLine($"Avarage = {avarage}");

            Console.Write($"Odd values:");
            for (int i = 0; i < myArray.Length; i++)
            {
               if (myArray[i]%2 != 0)
                Console.Write($" {myArray[i]}");
            }

            Console.ReadKey();
        }
    }
}
