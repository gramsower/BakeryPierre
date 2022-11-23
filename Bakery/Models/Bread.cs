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
      else if (NumberLoaves % 3 == 0)
      {
        int breadCost = NumberLoaves/3 * 10;
        return breadCost;
      }
      else
      {
        int breadRemainder = NumberLoaves % 3;
        int breadCost = (NumberLoaves - breadRemainder)/3 * 10 + (5*breadRemainder);
        return breadCost;
      }    
    }
  }
}
