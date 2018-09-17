using System;

namespace arry_positives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Random array:\n");

            int postives = 0;
            foreach (int number in arr)
            {
                if (number > 0) { postives++; }
            }

            Console.WriteLine($"The amount of positive number: {postives}");
        }

        static void fillArrayWithRandomNumbers(int[] arr) {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1000) - 500;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
