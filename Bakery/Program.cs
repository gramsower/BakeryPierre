using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("\n****************** \nWe Offer Bread And Pastries. \n~Bread: $5 per loaf \n~Pastry: $2 each \n****************** \n\nSPECIALS! \n\n~Buy two loaves and get the third one FREE (applies to every third bread loaf purchased). \n\n~Buy three, four, or five pastries and recieve a dollar off your order total. \n~Buy six or more pastries and get one free! \n******************");

      Console.WriteLine("How many bread loaves would you like today?");
      string breadInput = Console.ReadLine();
      int numberLoaves = int.Parse(breadInput);
      Console.WriteLine($"OK, {numberLoaves} loaves, coming right up!");

      Bread breadOrder = new Bread(numberLoaves);
      int breadCost = breadOrder.BreadCost();
      Console.WriteLine($"By the way, your bread subtotal is: ${breadCost}.00");

      Console.WriteLine("And how many pastries would you like today?");
      string pastryInput = Console.ReadLine();
      int numberPastries = int.Parse(pastryInput);
      Console.WriteLine($"OK, {numberPastries} pastries on the way!");

      Pastry pastryOrder = new Pastry(numberPastries);
      int pastryCost = pastryOrder.PastryCost();
      Console.WriteLine($"Your pastry subtotal is: ${pastryCost}.00");

      int totalCost = pastryCost + breadCost;
      Console.WriteLine($"Your total is ${totalCost}.00. \nThank you for your support!");
    }
  }
}