using System;

namespace ConsoleApp_task2
{
    class Program
    {
        static void Main()
        {          

            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 2;
            }

            Console.WriteLine("Your array test:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
                      

            Console.WriteLine("\nArray with the reverted values order:");
            for (int i = (myArray.Length - 1); i >= 0; i--)
            {                
                    Console.WriteLine(myArray[i]);
            }



            Console.ReadKey();
        }
    }
}
