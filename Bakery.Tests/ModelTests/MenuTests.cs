using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry testOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testOrder.GetType());
    }
    [TestMethod]
    public void PastryCost_Calculate6PastryCost_ReturnCost()
    {
      //Arrange
      int numberPastries = 6;
      Pastry testOrder = new Pastry(numberPastries);

      //Act
      int result = testOrder.PastryCost();

      //Assert
      Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void PastryCost_Calculate4PastryCost_ReturnCost()
    {
      //Arrange
      int numberPastries = 4;
      Pastry testOrder = new Pastry(numberPastries);

      //Act
      int result = testOrder.PastryCost();

      //Assert
      Assert.AreEqual(7, result);
    }
    [TestMethod]
    public void PastryCost_Calculate2PastryCost_ReturnCost()
    {
      //Arrange
      int numberPastries = 2;
      Pastry testOrder = new Pastry(numberPastries);

      //Act
      int result = testOrder.PastryCost();

      //Assert
      Assert.AreEqual(4, result);
    }
  }
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread testOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), testOrder.GetType());
    }
  }
}