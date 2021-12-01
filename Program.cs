using System;
using System.IO;

namespace AdventOfCode2021
{
    class Program
    {
        static readonly string textFile = @"C:\Users\joao.freire\RiderProjects\AdventOfCode2021\AdventOfCode2021\Input.txt";
        public static int[] Read(string textFile)
        {
            if (!File.Exists(textFile))
            {
                Console.WriteLine("Couldn't find Input file");
                return null;
            }
            Console.WriteLine("Found file!");
            
            string[] lines = File.ReadAllLines(textFile);
            int[] arr = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                arr[i] = int.Parse(lines[i]);
            }
            return arr;
        }
        
        static void Main(string[] args)
        {
            int[] Data = Read(textFile);
            Day1.WriteAnswer(Data);
        }
    }
}