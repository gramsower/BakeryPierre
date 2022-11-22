using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrder_CreateInstanceOfPastryOrder_Order()
    {
      PastryOrder testOrder = new PastryOrder("0");
      Assert.AreEqual(typeof(PastryOrder), testOrder.GetType());
    }

    [TestMethod]
    public void PastryOrder_ReturnsNumberOfPastries_ReturnsString()
    {
      //Arrange
      string numberPastries = "0";
      PastryOrder testOrder = new PastryOrder(numberPastries);

      //Act
      string result = testOrder.NumberPastries;

      //Assert
      Assert.AreEqual(numberPastries, result);
    }

  }
}