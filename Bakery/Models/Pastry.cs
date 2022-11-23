using System;
using System.Collections.Generic;
using Bakery;

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
