//using System;
//using System.Collections.Generic;
//using Bakery;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NumberPastries { get; set; }
    public Pastry (int numberPastries)
    {
      NumberPastries = numberPastries;
    }

    public int PastryCost()
    {
      if (NumberPastries >= 6)
      {
        int pastryCost = ((NumberPastries - 1) * 2);
        return pastryCost;
      }
      else if (NumberPastries == 3 || NumberPastries == 4 || NumberPastries == 5)
      {
        int pastryCost = (NumberPastries*2 - 1);
        return pastryCost;
      }
      else
      {
        int pastryCost = NumberPastries*2;
        return pastryCost;
      }
    }
  }
}
