namespace Bakery
{
  public class Pastry
  {
    public int ToBuy { get; set; }
    private int _cost;
    public int TotalCost {get; set;}
    public Pastry(int toBuy)
    {
      ToBuy = toBuy;
      _cost = 2;
      TotalCost = 0;
    }
    public void CalcCost()
    {
      int hasDiscount = ToBuy / 3;
      TotalCost += hasDiscount;
      for(int i = hasDiscount; i < ToBuy; i++)
      {
        TotalCost += _cost;
      }
    }
  }
}