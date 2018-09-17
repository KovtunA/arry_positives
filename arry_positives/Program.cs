using System;

namespace arry_positives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            fillArrayWithRandomNumbers(arr);

            Console.WriteLine("Random array:\n");
            printArray(arr);

            int positives = 0;
            foreach (int number in arr)
            {
                if (number > 0) { positives++; }
            }

            Console.WriteLine($"The amount of positive number: {positives}");
        }

        static void printArray(int[] massive)
        {
            foreach (int value in massive) { Console.WriteLine(value); }
        }

        static void fillArrayWithRandomNumbers(int[] arr) {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1000) - 500;
            }
        }
    }
}
