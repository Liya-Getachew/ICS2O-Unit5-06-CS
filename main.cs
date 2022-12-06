// Created by: liya getachew
// Created on: Dec 6 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function tells the user if they're eligible for discount
        int value1;
        int value2;
        int counter = 0;
        int sum = 0;

        Console.WriteLine("Multiplication (kinda)");
        Console.WriteLine("Enter 2 integers here:");
        Console.WriteLine("");

        Console.WriteLine("value 1: ");
        value1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("value 2: ");
        value2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        while (counter < value2)
        {
          sum += value1;
          counter++;
        }

        Console.WriteLine(value1 + " x " + value2 + " = " + sum);
        Console.WriteLine("\nDone.");
    }
}