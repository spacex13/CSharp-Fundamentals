using System;

namespace _08.RecursiveFibonacci
{
    class Program
    {
        private static long[] numbers;

        public static long GetFibonacci(int n)
        {
            if (numbers[n] == 0)
            {
                numbers[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2); ;
            }

            return numbers[n];
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;
            long result = GetFibonacci(n);

            Console.WriteLine(result);         
        }
    }
}
