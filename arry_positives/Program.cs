using System;

namespace arry_positives
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] arr = new int[10];
            Console.WriteLine("Random array:\n");
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1000) - 500;
                Console.WriteLine(arr[i]);
            }

            foreach (int number in arr)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"The amount of positive number: {result}");

        }
    }
}
