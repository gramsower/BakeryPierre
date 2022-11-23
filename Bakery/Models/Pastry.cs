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
      else
      {
        return 0;
      }
    }
  }
}
