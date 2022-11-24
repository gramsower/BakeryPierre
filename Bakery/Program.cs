using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\nWelcome to Pierre's Bakery!");
      Console.WriteLine("\n****************** \nWe Offer Bread And Pastries. \n~Bread: $5 per loaf \n~Pastry: $2 each \n****************** \n\nSPECIALS! \n\n~Buy two loaves and get the third one FREE (applies to every third bread loaf purchased). \n\n~Buy three, four, or five pastries and recieve a dollar off your order total. \n~Buy six or more pastries and get one free! \n******************");

      Console.WriteLine("How many bread loaves would you like today? (If none, enter 0).");
      string breadInput = Console.ReadLine();
      int numberLoaves = int.Parse(breadInput);
      if (numberLoaves >1)
      {
        Console.WriteLine($"OK, {numberLoaves} loaves, coming right up!");
      }
      else
      {
        Console.WriteLine($"OK, just {numberLoaves} loaf, coming right up!");;
      }
      Bread breadOrder = new Bread(numberLoaves);
      int breadCost = breadOrder.BreadCost();
      
      Console.WriteLine("And how many pastries would you like today? (If none, enter 0.");
      string pastryInput = Console.ReadLine();
      int numberPastries = int.Parse(pastryInput);
      if (numberPastries >1)
      {
        Console.WriteLine($"OK, {numberPastries} pastries on the way!");
      }
      else
      {
        Console.WriteLine($"OK...I guess... only {numberPastries} pastry on the way! You certainly have a lot of self control!");
      }
      Pastry pastryOrder = new Pastry(numberPastries);
      int pastryCost = pastryOrder.PastryCost();

      int totalCost = pastryCost + breadCost;
      int rawTotal = (numberLoaves*5) + (numberPastries*2);
      int totalSavings = rawTotal - totalCost;

      Console.WriteLine($"Your bread subtotal is: ${breadCost}.00");
      Console.WriteLine($"Your pastry subtotal is: ${pastryCost}.00");
      Console.WriteLine($"Your total is ${totalCost}.00. \nYou saved {totalSavings}.00 today! \nThank you for your support of local businesses like ours!");

      Console.WriteLine("Would you like to place another order? (enter y/n)");
      string userRerun = Console.ReadLine();
      if (userRerun.ToLower() == "y")
      {
        Main();
      }
      Console.WriteLine("Goodbye.");
      Environment.Exit(0);
    }
  }
}