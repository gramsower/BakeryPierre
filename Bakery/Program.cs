using System;
using System.Collections.Generic;
// using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We Offer Bread And Pastries. \n~Bread: $5 per loaf \n~Pastry: $2 each \n****************** \n\nSPECIALS! \n~Buy two loaves and get the third one FREE (applies to every third bread loaf purchased.) \n\n~Buy three, four, or five pastries and recieve a dollar off your order total. \n~Buy six or more pastries and get one free! \n");

      Console.WriteLine("How many bread loaves would you like today?");
      string breadInput = Console.ReadLine();
      int numberBreadLoaves = Convert.ToInt32(breadInput);
      Console.WriteLine($"OK, that's {numberBreadLoaves} loaves, correct?");
      
      Console.WriteLine("And how many pastries would you like today?");
      string pastryInput = Console.ReadLine();
      int numberPastries = Convert.ToInt32(pastryInput);
      Console.WriteLine($"OK, that's {numberPastries} pastries, correct?");


      
    }
  }
}

