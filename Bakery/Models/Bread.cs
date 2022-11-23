using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery.Models
{
  public class BreadOrder
  {
    public int AmountBreadLoaves { get; set; }
    public BreadOrder (int amountBreadLoaves)
    {
      AmountBreadLoaves = amountBreadLoaves;
    }
  }
}
