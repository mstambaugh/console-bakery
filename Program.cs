using System;
using System.Collections.Generic;
using Bakery;

namespace Order 
{
  public class Program
  {
    public static void Main()
    {
      Bread breadsorder = new Bread();
      
      Pastries pastriesorder = new Pastries();

      Console.WriteLine("\n\n<(✜)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)><(o)>~~<(o)><(o)>~~<(✜)>");
      Console.WriteLine("\n|| Bienvenue à la Boulangerie de Pierre!\n|| We offer a fine selection of artisinal French bread and pastries\n|| Would you like to place an order now\n|| or take a moment to read our menu and hear our special offers?");
      Console.WriteLine("\n<(✜)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)>~~<(o)><(o)>~~<(o)><(o)>~~<(✜)>");
      bool OrderComplete = false;
      while (!OrderComplete)
      {
        Console.WriteLine("\nMenu? (please enter 'menu')\nOrder? (please enter 'order')");
        string input = Console.ReadLine();
        if (input.ToUpper() == "MENU")
        {
          Console.WriteLine("<(✜)>~~<(o)><()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()><(o)>~~<(✜)>");
          Console.WriteLine("Offres Spéciales du Jour");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine("Bread: Levain Batard €5 each\n\t buy two and recieve the third loaf free" );
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine("Pastry: Pain Au Chocolat: €2 each\n\t three for €5");
          Console.WriteLine("<(✜)>~~<(o)><()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()><(o)>~~<(✜)>");
        }
        else if (input.ToUpper() == "ORDER")
        {
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine("How many loaves would you like?");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          breadsorder.BreadQuantity = int.Parse(Console.ReadLine());
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine("How many pastries would you like?");
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          pastriesorder.PastryQuantity = int.Parse(Console.ReadLine());
          Console.WriteLine("Your total will be € " + (breadsorder.GetBreadPrice() + pastriesorder.GetPastryPrice()));
          Console.WriteLine("Here are your " + breadsorder.BreadQuantity + " Levain Batard and " + pastriesorder.PastryQuantity + " Pain Au Chocolat");
          Console.WriteLine("<(✜)>~~<(o)><()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()>~~<()><(o)>~~<(✜)>");
          OrderComplete = true;
        }
        else
        {
          Console.WriteLine("✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜");
          Console.WriteLine("\nEst-ce que tu parles français?\n");
          Console.WriteLine("✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜✜");
        }
      }
    }
  }
}