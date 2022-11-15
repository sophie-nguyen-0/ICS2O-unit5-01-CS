// Created by: sophie
// Created on: oct 2020
//
// This program calculates area and perimeter of a rectangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        int length;
        int width;
        int area;
        int perimeter;

        Console.WriteLine("calculates the area and perimeter of a rectangle.");
        Console.WriteLine("");

        Console.Write("Enter length (cm): ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width (cm): ");
        width = Convert.ToInt32(Console.ReadLine());

        area = length * width;
        perimeter = 2 * (length + width);

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");
        Console.WriteLine("perimeter is: " + perimeter + " cm. ");

        Console.WriteLine("\nDone.");
    }
}