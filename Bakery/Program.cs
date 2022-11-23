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
      Console.WriteLine("We Offer Bread And Pastries. \nBread: $5 per loaf \nPastry: $2 each \n****************** \n\nSPECIALS! \nBuy two loaves and get the third one FREE (applies to every third bread loaf purchased.) \n\nBuy three, four, or five pastries and recieve a dollar off your order total. \nBuy six or more pastries and get one free! \n");

      Console.WriteLine("How many bread loaves would you like today?");
      string breadInput = Console.ReadLine();
      int numberPastrises = Convert.ToInt32(breadInput);

      Console.WriteLine("How many pastries would you like today?");
      string pastryInput = Console.ReadLine();
      int numberPastries = Convert.ToInt32(pastryInput);


      
    }
  }
}

