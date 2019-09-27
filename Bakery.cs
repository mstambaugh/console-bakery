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
      // return quantity 
    }
    public int GetTotalPrice()
    {
      // return quantity * price. if quantity % 2 == 0, then total price == .
    }
  }
  class Pastries 
  {
    public string Pastry { get; set; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }
    public Pastries(string pastry, int quantity, int totalprice)
    {
      Pastry = pastry;
      Quantity = quantity;
      TotalPrice = totalprice;
    }
  }
}