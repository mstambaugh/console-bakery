using System;
using System.Collections.Generic;
using Bakery;

namespace Order 
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread("Loaf", 0, 0 );
      
      Pastries pastries = new Pastries("Pastry", 0, 0);
     
    
      Console.WriteLine("Bienvenue à la Boulangerie de Pierre! We offer a fine selection of artisinal French bread and pastries. Would you like to place an order now, or take a moment to read our menu and hear our special offers? \n\tMenu? (please enter 'menu')\n\tOrder? (please enter 'order')");
      string input = Console.ReadLine();

      if (input.ToUpper() == "MENU")
      {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Today's Specials");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Levain Batard: €5\n\t buy two and recieve the third loaf free" );
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Pain Au Chocolat: €2\n\t three for €5");
      }
      else if (input.ToUpper() == "ORDER")
        Console.WriteLine("How many loaves would you like?");
        Console.ReadLine();
        Console.WriteLine("How many pastries would you like?");
        Console.ReadLine();
        Console.WriteLine("your total today will be");
        
    }
  }

}