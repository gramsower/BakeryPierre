//using System;
// using System.Collections.Generic;
// using Bakery;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberLoaves { get; set; }
    public Bread (int numberLoaves)
    {
      NumberLoaves = numberLoaves;
    }

    public int BreadCost()
    {
      if (NumberLoaves == 1)
      {
        int breadCost = NumberLoaves * 5;
        return breadCost;
      }
      else 
      {
        return 0;
      }
  }
}
