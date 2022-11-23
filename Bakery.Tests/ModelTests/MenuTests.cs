using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry__Pastry()
    {
      Pastry testOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testOrder.GetType());
    }

    /* [TestMethod]
    public void PastryOrder_ReturnAmountOfPastries_ReturnsNumber()
    {
      //Arrange
      int amountPastries = 1;
      Pastry testOrder = new Pastry(amountPastries);

      //Act
      int result = testOrder.AmountPastries;

      //Assert
      Assert.AreEqual(amountPastries, result);
    }*/
    
    [TestMethod]
    public void PastryOrderCost_Calculate6PastryCost_ReturnPastryTotal()
    {
      //Arrange
      int amountPastries = 6;
      Pastry testOrder = new Pastry(amountPastries);

      //Act
      int result = testOrder.PastryOrderCost();

      //Assert
      Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void PastryOrderCost_Calculate4PastryCost_ReturnPastryTotal()
    {
      //Arrange
      int amountPastries = 4;
      Pastry testOrder = new Pastry(amountPastries);

      //Act
      int result = testOrder.PastryOrderCost();

      //Assert
      Assert.AreEqual(7, result);
    }
    [TestMethod]
    public void PastryOrderCost_Calculate2PastryCost_ReturnPastryTotal()
    {
      //Arrange
      int amountPastries = 2;
      Pastry testOrder = new Pastry(amountPastries);

      //Act
      int result = testOrder.PastryOrderCost();

      //Assert
      Assert.AreEqual(4, result);
    }
  }
}