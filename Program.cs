using System;
using System.Collections.Generic;
using Bakery;

namespace Order 
{
  public class Program
  {
    public static void Main()
    {
      Bread breadorder = new Bread("Loaf", 0, 0);
      
      Pastries pastriesorder = new Pastries("Pastry", 0, 0);

      Console.WriteLine("\n\n<(✜)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)><(o)>~~<(o)><(o)>~~<(✜)>");
      Console.WriteLine("\n|| Bienvenue à la Boulangerie de Pierre!\n|| We offer a fine selection of artisinal French bread and pastries\n|| Would you like to place an order now\n|| or take a moment to read our menu and hear our special offers? \n\n\tMenu? (please enter 'menu')\n\n\tOrder? (please enter 'order')");
      Console.WriteLine("\n<(✜)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)><(o)>~~<(o)><(o)>~~<(✜)>");
      string input = Console.ReadLine();

      if (input.ToUpper() == "MENU")
      {
        Console.WriteLine("<(✜)>~~<(o)><()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()><(o)>~~<(✜)>");
        Console.WriteLine("Offres Spéciales du Jour");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Levain Batard: €5 each\n\t buy two and recieve the third loaf free" );
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Pain Au Chocolat: €2 each\n\t three for €5");
        Console.WriteLine("<(✜)>~~<(o)><()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()><(o)>~~<(✜)>");
      }
      else if (input.ToUpper() == "ORDER")
      {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("How many loaves would you like?");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        int Quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("How many pastries would you like?");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        int Quantity2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Your total will be € " + TotalPrice);
        Console.WriteLine("You ordered " + Quantity + " Levain Batard and " + Quantity2 + " Pain Au Chocolat");
        Console.WriteLine("<(✜)>~~<(o)><()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()><(o)>~~<(✜)>");
      }
      else
      {
        Console.WriteLine("✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜");
        Console.WriteLine("\nEst-ce que tu parles français?\n");
        Console.WriteLine("✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜");
        Main();
      }
    }
  }
}