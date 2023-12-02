using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] input = File.ReadAllLines("C:\\Users\\Monat\\Desktop\\Web\\Personal\\AOC2023\\Day1\\AOC2023_Day1\\input\\input.txt");

        foreach (string line in input)
        {
            Console.WriteLine(line);
        }

        Console.ReadLine();
    }


}

