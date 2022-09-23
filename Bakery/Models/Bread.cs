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
      _cost = 5;
      TotalCost = 0;

    }

    public void CalcCost() //buy 2 get 1 free
    {
      int hasFree = 0;
      int totalCost = 0;
      if(ToBuy % 3 == 0) {hasFree = 1;}
      for(int i = hasFree; i < ToBuy; i++)
      {
        totalCost += _cost;
      }
      TotalCost = totalCost;
    }
  }
}