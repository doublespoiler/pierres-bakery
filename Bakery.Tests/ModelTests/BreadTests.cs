using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
  [TestMethod]

    public void CalcCost_BuyOneForTwoDollars_True()
    {
      //any logic prep goes here
      Bread buyOne = new Bread(1);
      buyOne.CalcCost();
      Assert.AreEqual(5, buyOne.TotalCost);
    }

  [TestMethod]
    public void CalcCost_BuyTwoForFourDollars_True()
    {
      Bread buyTwo = new Bread(2);
      buyTwo.CalcCost();
      Assert.AreEqual(10, buyTwo.TotalCost);
    }
      
  [TestMethod]
    public void CalcCost_BuyTwoGetOneFree_True()
    {
      Bread buyThree = new Bread(3);
      buyThree.CalcCost();
      Assert.AreEqual(10, buyThree.TotalCost); //paying for 2 (1 free)
    }

  [TestMethod]
    public void CalcCost_BuyFive_True()
    {
      Bread buyFive = new Bread(5);
      buyFive.CalcCost();
      Assert.AreEqual(20, buyFive.TotalCost); //paying for 4 (1 free)
    }

  [TestMethod]
    public void CalcCost_BuySix_True()
    {
      Bread buySix = new Bread(6);
      buySix.CalcCost();
      Assert.AreEqual(20, buySix.TotalCost); //paying for 4 (2 free)
    }
  }
}