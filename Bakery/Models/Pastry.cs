using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery.Models
{
  public class Pastry
  {
    public int AmountPastries { get; set; }
    public Pastry (int amountPastries)
    {
      AmountPastries = amountPastries;
    }

    public int PastryOrderCost()
    {
      if (AmountPastries >= 6)
      {
        int pastryCost = ((AmountPastries - 1) * 2);
        return pastryCost;
      }
      else if (AmountPastries == 3 || AmountPastries == 4 || AmountPastries == 5)
      {
        int pastryCost = (AmountPastries*2 - 1);
        return pastryCost;
      }
      else
      {
        int pastryCost = AmountPastries*2;
        return pastryCost;
      }
    }
  }
}
