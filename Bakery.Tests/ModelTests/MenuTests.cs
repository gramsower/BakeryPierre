using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastryOrder_Order()
    {
      PastryOrder tesOrder = new PastryOrder();
      Assert.AreEqual(typeof(PastryOrder), testOrder.GetType());
    }

  }
}