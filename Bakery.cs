namespace Bakery
{
  class Bread 
  {
    // auto-implemented properties 
    // public string Loaf { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; } 

    // bread constructor
    public Bread(int breadquantity, int breadprice) 
    {
      BreadQuantity = breadquantity;
      BreadPrice = breadprice;
    }
    // bread methods
    public int GetBreadQuantity()
    {
      return BreadQuantity;
    }
    public int GetBreadPrice()
    {
      int FreeLoaves = 0;
      // if (Quantity > 2 || Quantity % 3 == 0 || (Quantity % 3) > 1)
      if (BreadQuantity > 1)
      {
        FreeLoaves = BreadQuantity/3;
        BreadPrice = (BreadQuantity * 5) - (FreeLoaves * 5);
        BreadQuantity += FreeLoaves; 
      }
      else
      {
        BreadPrice = BreadQuantity * 5;
      }
      return BreadPrice;
    }
  }   

  class Pastries 
  {
    public string Pastry { get; set; }
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public Pastries(int pastryquantity, int pastryprice)
    {
      PastryQuantity = pastryquantity;
      PastryPrice = pastryprice;
    }
    public int GetPastryQuantity()
    {
      return PastryQuantity;
    }
    public int GetPastryPrice()
    {
      // Buy 1 for \$2 or 3 for $5.
      // 13/3 = 4 * 5 = 20, 
      int CheapPastries = PastryQuantity / 3;
      int ExpensivePastries = PastryQuantity % 3;
      PastryPrice = (CheapPastries * 5) + (ExpensivePastries * 2);
      return PastryPrice;
    }
  }
}