using System;
using System.IO;

namespace AdventOfCode2021
{
    class Program
    {
        static readonly string textFile = @"D:\Documents\Github Repositories\AdventOfCode2021\Input.txt";
        
        public static string[] ReadInput(string textFile)
        {
            if (!File.Exists(textFile))
            {
                Console.WriteLine("Couldn't find Input file");
                return null;
            }
            Console.WriteLine("Found file!");
            
            string[] lines = File.ReadAllLines(textFile);
            return lines;
        }
        
        static void Main(string[] args)
        {
            string[] inputText = ReadInput(textFile);
            
            Day2.WriteAnswer(inputText);
        }
    }
}