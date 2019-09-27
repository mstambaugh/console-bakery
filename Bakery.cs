namespace Bakery
{
  class Bread 
  {
    // auto-implemented properties 
    // public string Loaf { get; set; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; } 

    // bread constructor
    public Bread(int quantity, int totalprice) 
    {
      // Loaf = loaf;
      Quantity = quantity;
      TotalPrice = totalprice;
    }
    // bread methods
    public int GetQuantity()
    {
      return Quantity;
    }
    public int GetTotalPrice()
    {
      int Freeloaves = 0;
      if (Quantity > 2 || Quantity % 3 == 0 || (Quantity % 3) > 1)
      {
        FreeLoaves = Quantity/3;
        TotalPrice = (Quantity * 5) - (FreeLoaves * 5);
        Quantity += FreeLoaves; 
      }
      else
      {
        TotalPrice = Quantity * 5;
      }
      return TotalPrice;
    }
  }   

  class Pastries 
  {
    public string Pastry { get; set; }
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public Pastries(string pastry, int PastryQuantity, int PastryPrice)
    {
      Pastry = pastry;
      PastryQuantity = pastryquantity;
      PastryPrice = pastryprice;
    }
    public int GetPastryQuantity()
    {
      return PastryQuantity;
    }
    public int GetPastryTotalPrice()
    {
      int CheapPastries = 0;
      // Buy 1 for \$2 or 3 for $5.
      if (PastryQuantity % 3 == 0)
      {
        PastryPrice = (PastryQuantity / 3 ) * 5;
      }
      if (PastryQuantity > 3)
      {
        // 13/3 = 4 * 5 = 20, 
        CheapPastries = PastryQuantity / 3;
        ExpensivePastries = PastryQuantity % 3;
        PastryPrice = (CheapPastries * 5) + (ExpensivePastries *2);
      }
      else
      {
        PastryPrice = Quantity * 2;
      }
      return TotalPrice;
    }
  }
}