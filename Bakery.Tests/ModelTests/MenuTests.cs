using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrder_CreateInstanceOfPastryOrder_Order()
    {
      PastryOrder testOrder = new PastryOrder(0);
      Assert.AreEqual(typeof(PastryOrder), testOrder.GetType());
    }

    [TestMethod]
    public void PastryOrder_ReturnAmountOfPastries_ReturnsNumber()
    {
      //Arrange
      int amountPastries = 0;
      PastryOrder testOrder = new PastryOrder(amountPastries);

      //Act
      int result = testOrder.AmountPastries;

      //Assert
      Assert.AreEqual(amountPastries, result);
    }   
  }
}