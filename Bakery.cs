namespace Bakery
{
  class Bread 
  {
    // auto-implemented properties 
    // public string Loaf { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadPrice { get; set; } 

    // bread constructor
    public Bread() 
    {
      
    }
    // bread methods
    
    public int GetBreadPrice()
    {
      // buy 2, get 1 free, 5 dollars each 
      // 13/3 = 4*10 = 40, % 1 * 5 = 45
      // old math (if (Quantity > 2 || Quantity % 3 == 0 || (Quantity % 3) > 1)
      BreadPrice = ((BreadQuantity / 3) * 10) + ((BreadQuantity % 3) * 5);
      if (BreadQuantity % 3 == 2)
      {
        BreadQuantity += 1;
      }
      return BreadPrice;
    }
  }   

  class Pastries 
  {
    public int PastryQuantity { get; set; }
    public int PastryPrice { get; set; }
    public Pastries()
    {
      
    }
    
    public int GetPastryPrice()
    {
      // Buy 1 for $2 or 3 for $5.
      // 13/3 = 4 * 5 = 20 + 2 = $22, 
      int CheapPastries = PastryQuantity / 3;
      int ExpensivePastries = PastryQuantity % 3;
      PastryPrice = (CheapPastries * 5) + (ExpensivePastries * 2);
      return PastryPrice;
    }
  }
}