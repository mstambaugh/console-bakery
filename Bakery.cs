namespace Bakery
{
  class Bread {
    // auto-implemented properties 
    public int Quantity { get; set; }
    public int TotalPrice { get; set; } 

    // bread constructor
    public Bread(int quantity, int totalprice) 
    {
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
  class Pastry {
    public Pastry(int quantity, int totalprice)
    {
      Quantity = quantity;
      TotalPrice = totalprice;
    }
  }


}