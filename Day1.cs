using System;

namespace AdventOfCode2021
{
    public static class Day1
    {
        public static int SolveP1(int[] data)
        {
            int increases = 0;

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i + 1] > data[i])
                {
                    increases++;
                }
            }
            return increases;
        }
        
        public static int SolveP2(int[] data)
        {
            int[] arr = new int[data.Length];
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i; j < i + 3; j++)
                {
                    if (j == data.Length) { return SolveP1(arr); }
                    arr[i] += data[j];
                }
            }
            return -1;
        }

        public static void WriteAnswer(int[] data)
        {
            Console.WriteLine("Day 1");
            Console.WriteLine($"Part 1: {SolveP1(data)}");
            Console.WriteLine($"Part 2: {SolveP2(data)}");
        }
    }
}