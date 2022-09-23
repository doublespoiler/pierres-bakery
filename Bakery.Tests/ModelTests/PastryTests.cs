using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
  [TestMethod]
    public void CalcCost_BuyOneForTwoDollars_True()
    {
      Pastry buyOne = new Pastry(1);
      buyOne.CalcCost();
      Assert.AreEqual(2, buyOne.TotalCost);
    }

    [TestMethod]
      public void CalcCost_BuyTwoForFourDollars_True()
      {
        Pastry buyTwo = new Pastry(2);
        buyTwo.CalcCost();
        Assert.AreEqual(4, buyTwo.TotalCost);
      }
    [TestMethod]
      public void CalcCost_BuyThreeForFiveDollars_True()
      {
        Pastry buyThree = new Pastry(3);
        buyThree.CalcCost();
        Assert.AreEqual(5, buyThree.TotalCost);
      }

    [TestMethod]
      public void CalcCost_BuyFourForSeven_True()
      {
        Pastry buyFour = new Pastry(4);
        buyFour.CalcCost();
        Assert.AreEqual(7, buyFour.TotalCost);
      }
  }
}