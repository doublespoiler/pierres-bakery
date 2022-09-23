namespace Bakery
{
  public class Bread
  {
    
    public int ToBuy { get; set; }
    private int _cost;
    public int TotalCost {get; set;}

    public Bread(int toBuy)
    {
      ToBuy = toBuy;
      _cost = 2;
      TotalCost = 0;

    }

    public void CalcCost() //buy 2 get 1 free
    {
      int totalCost = 0;
      for(int i = 0; i < ToBuy; i++)
      {
        totalCost += _cost;
      }
      TotalCost = totalCost;
    }
  }
}