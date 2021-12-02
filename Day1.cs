using System;

namespace AdventOfCode2021
{
    public class Day1
    {
        public static int[] ProcessInput(string[] lines)
        {
            int[] arr = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                arr[i] = int.Parse(lines[i]);
            }
            return arr;
        }
        
        private static int SolveP1(int[] data)
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
        
        private static int SolveP2(int[] data)
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

        public static void WriteAnswer(string[] inputText)
        {
            int[] data = ProcessInput(inputText);
            Console.WriteLine("Day 1");
            Console.WriteLine($"> Part 1: {SolveP1(data)}");
            Console.WriteLine($"> Part 2: {SolveP2(data)}");
        }
    }
}