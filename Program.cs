using System;
using System.Collections.Generic;
using Bakery;

namespace Order 
{
  public class Program
  {
    public static void Main()
    {
      Bread order = new Bread("Bread", 0, 0 );
      order.Start();
      Pastry order = new Pastry("Pastry", 0, 0);
      order.Start();
    
      Console.WriteLine("Bienvenue à la Boulangerie de Pierre! We offer a fine selection of artisinal French bread and pastries. Would you like to place an order now, or take a moment to look at our menu and special offers? \nMenu? (please enter 'menu')\nOrder? (please enter 'order')");
      string input = Console.ReadLine();
      
      if (input.ToUpper() == "MENU")
      {

      }
    }
  }

}