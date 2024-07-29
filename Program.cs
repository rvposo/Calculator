﻿namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
       Sum();

    }
    static void Sum()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float firstValue = float.Parse(Console.ReadLine());
        //float.Parse(Console.ReadLine());

        Console.WriteLine("Second value: ");
        float secondValue = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float result = firstValue + secondValue;
        Console.WriteLine($"Sum output is: {result}");
    }

}