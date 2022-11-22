using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class PastryOrder
  {
    public int AmountPastries { get; set; }
    public PastryOrder (int amountPastries)
    {
      AmountPastries = amountPastries;
    }
  }
}
