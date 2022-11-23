using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    [TestMethod]
    public void BreadCost_Calculate1LoafCost_ReturnCost()
    {
      //Arrange
      int numberLoaves = 1;
      Bread testOrder = new Bread(numberLoaves);

      //Act
      int result = testOrder.BreadCost();

      //Assert
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BreadCost_Calculate6LoafCost_ReturnCost()
    {
      //Arrange
      int numberLoaves = 6;
      Bread testOrder = new Bread(numberLoaves);

      //Act
      int result = testOrder.BreadCost();

      //Assert
      Assert.AreEqual(20, result);
    }
    [TestMethod]
    public void BreadCost_Calculate10LoafCost_ReturnCost()
    {
      //Arrange
      int numberLoaves = 10;
      Bread testOrder = new Bread(numberLoaves);

      //Act
      int result = testOrder.BreadCost();

      //Assert
      Assert.AreEqual(35, result);
    }
  }
}