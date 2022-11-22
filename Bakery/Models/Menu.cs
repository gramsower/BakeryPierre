using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class PastryOrder
  {
    public string NumberPastries { get; }

    public PastryOrder(string numberPastries)
    {
      NumberPastries = numberPastries;
    }
  }
}
