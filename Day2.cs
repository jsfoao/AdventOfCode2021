using System;

namespace AdventOfCode2021
{
    public class Day2
    {
        public static Command[] Commands;
        public static Submarine Submarine;
        public static void ProcessInput(string[] lines)
        {
            Commands = new Command[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split();
                Commands[i].Direction = words[0];
                Commands[i].Units = int.Parse(words[1]);
            }
        }

        public static int SolveP1()
        {
            Submarine = new Submarine(Position.zero);
            for (int i = 0; i < Commands.Length; i++)
            {
                if (Commands[i].Direction == "forward")
                {
                    Submarine.Position.Horizontal += Commands[i].Units;
                }
                else if (Commands[i].Direction == "up")
                {
                    Submarine.Position.Depth -= Commands[i].Units;
                }
                else if (Commands[i].Direction == "down")
                {
                    Submarine.Position.Depth += Commands[i].Units;
                }
            }
            return Submarine.Position.Horizontal * Submarine.Position.Depth;
        }
        
        public static int SolveP2()
        {
            Submarine = new Submarine(Position.zero);
            for (int i = 0; i < Commands.Length; i++)
            {
                if (Commands[i].Direction == "forward")
                {
                    Submarine.Position.Horizontal += Commands[i].Units;
                    Submarine.Position.Depth += Submarine.Aim * Commands[i].Units;
                }
                else if (Commands[i].Direction == "up")
                {
                    Submarine.Aim -= Commands[i].Units;
                }
                else if (Commands[i].Direction == "down")
                {
                    Submarine.Aim += Commands[i].Units;
                }
            }
            return Submarine.Position.Horizontal * Submarine.Position.Depth;
        }

        public static void WriteAnswer(string[] inputText)
        {
            ProcessInput(inputText);
            Console.WriteLine("Day 2");
            Console.WriteLine($"> Part 1: {SolveP1()}");
            Console.WriteLine($"> Part 2: {SolveP2()}");
        }
    }

    public class Submarine
    {
        public Position Position;
        public int Aim;

        public Submarine(Position position, int aim = 0)
        {
            Position = position;
            Aim = aim;
        }
    }

    public struct Position
    {
        public int Horizontal;
        public int Depth;

        public static Position zero = new Position();

        public Position(int horizontal = 0, int depth = 0)
        {
            Horizontal = horizontal;
            Depth = depth;
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position
            {
                Depth = p1.Depth + p2.Depth,
                Horizontal = p1.Horizontal + p2.Horizontal
            };
        }
        public static Position operator -(Position p1, Position p2)
        {
            return new Position
            {
                Depth = p1.Depth - p2.Depth,
                Horizontal = p1.Horizontal - p2.Horizontal
            };
        }
        public static Position operator *(Position p, int num)
        {
            return new Position
            {
                Depth = p.Depth * num,
                Horizontal = p.Horizontal * num
            };
        }
    }

    public struct Command
    {
        public string Direction;
        public int Units;
    }
}