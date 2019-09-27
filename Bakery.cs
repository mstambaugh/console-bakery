namespace Bakery
{
  class Bread 
  {
    // auto-implemented properties 
    public string Loaf { get; set; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; } 

    // bread constructor
    public Bread(string loaf, int quantity, int totalprice) 
    {
      Loaf = loaf;
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
}
  class Pastries 
  {
    public string Pastry { get; set; }
    public int Quantity2 { get; set; }
    public int TotalPrice { get; set; }
    public Pastries(string pastry, int quantity2, int totalprice)
    {
      Pastry = pastry;
      Quantity2 = quantity2;
      TotalPrice = totalprice;
    }
  }
}