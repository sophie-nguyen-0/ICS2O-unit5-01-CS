// Created by: sophie
// Created on: oct 2020
//
// This program calculates area and perimeter of a rectangle

using System;

class Program
{
    public static void Main(string[] args)
    {
      int number;
      int num;

      System.Random random = new System.Random(); 
      
      Console.Write("Enter a number from 1-6 ");
        number = Convert.ToInt32(Console.ReadLine());

      num = random.Next(6);

      if (number == num){
        Console.WriteLine("you did it!");
      }
        Console.WriteLine("\nDone.");
    }
}