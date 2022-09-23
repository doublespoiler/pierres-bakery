using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery
{
    public class Program
    {
      public static void Main(){
        Console.Clear();
        StartMenu();

      }

      private static void StartMenu(){
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|    Welcome to Pierre's Bakery    |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread...........................$5|");
        Console.WriteLine("|Pastry..........................$2|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|Bread: B2G1 Free   Pastry: B2G1 $1|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("Press any key to continue, esc to leave...");
        if(Console.ReadKey().Key == ConsoleKey.Escape)
        {
          Console.Clear();
          Console.WriteLine(" B"); //I need this line in order for the rest of the lines to show up, for some reason
          Console.WriteLine("Pierre: \"Goodbye.\"");
          Console.WriteLine("You leave.");
        } 
        else 
        {
          BuyBread();
        }
      }
      private static void BuyBread()
      {
        Console.Clear();
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread...........................$5|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|Bread: B2G1 Free                  |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("How many loaves of bread you would like to buy?");
        int breadToBuy;
        bool success = int.TryParse(Console.ReadLine(), out breadToBuy);
        if (success)
        {
          BuyPastry(breadToBuy);
        } 
        else 
        {
          Console.WriteLine("Invalid Selection, please try again.");
          BuyBread();
        }
      }
      private static void BuyPastry(int breadToBuy)
      {
        Console.Clear();
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Pastry..........................$2|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|Pastry: B2G1 $1                   |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("How many pastries you would like to buy?");
        int pastryToBuy;
        bool success = int.TryParse(Console.ReadLine(), out pastryToBuy);
        if (success)
        {
          int[] checkOut = {breadToBuy, pastryToBuy};
          CheckOut(checkOut);
        } 
        else 
        {
          Console.WriteLine("Invalid Selection, please try again.");
          BuyPastry(breadToBuy);
        }
      }

      private static void CheckOut(int[] checkOut)
      {
        Bread buyBread = new Bread(checkOut[0]);
        Pastry buyPastry = new Pastry(checkOut[1]);
        buyBread.CalcCost();
        buyPastry.CalcCost();
        int total = buyBread.TotalCost + buyPastry.TotalCost;

        int breadLength = 23 - buyBread.TotalCost.ToString().Length;
        int pastryLength = 22 - buyPastry.TotalCost.ToString().Length;
        int totalLength = 25 - total.ToString().Length;

        string breadLine = "";
        string pastryLine = "";
        string totalLine = "";

        for(int i = 0; i < breadLength - checkOut[0].ToString().Length; i++){ breadLine += ".";}
        for(int i = 0; i < pastryLength - checkOut[1].ToString().Length; i++){ pastryLine += ".";}
        for(int i = 0; i< totalLength; i++){ totalLine += ".";}

        Console.Clear();
        
        Console.WriteLine("*----------------------------------*");//34
        Console.WriteLine("|             Reciept              |");
        Console.WriteLine("|          Pierres Bakery          |");
        Console.WriteLine("|          1234 Center St          |");
        Console.WriteLine("|     East Grestin, Arstotzka      |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread x" + checkOut[0]  + breadLine + "$"+ buyBread.TotalCost.ToString() +".00|");
        Console.WriteLine("|Pastry x" + checkOut[1] +  pastryLine + "$"+ buyPastry.TotalCost.ToString() +".00|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Total" + totalLine + "$"+ total.ToString() +".00|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|        Glory To Arstotzka        |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("Press any key to exit...");
        if(Console.ReadKey().Key == ConsoleKey.G )
        {
          EasterEgg();
        }
        else
        {
          Console.Clear();
          Console.WriteLine("You lose $" + total);
          Console.WriteLine("Pierre: \"Glory to Arstotzka\"");
          Console.WriteLine("You leave with your bread.");
        }
      }

      private static void EasterEgg()
      {
        Console.Clear();
        Console.WriteLine("*------------------------------------------------------------*");
        Console.WriteLine("|''''''''''''''''''''''''''GLORY TO''''''''''''''''''''''''''|");
        Console.WriteLine("|'''''''''''''''''''''''''ARZTOTSKA!'''''''''''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''|");
        Console.WriteLine("|';oxxxxxxxxxxxxxxdc,''''''''''',ldc,'''',cdxxxxxxxxxxxxxxo;'|");
        Console.WriteLine("|'':x0XNNNNNNNNNNXXKxc,'''';lddxxxoc;'',cxKXNNXNNNNNNNNX0x:,'|");
        Console.WriteLine("|''',:x0XNNNXXXNXNNXX0c''',dKXXXkc:c:';xKXNNXXNNNXXXNX0x:''''|");
        Console.WriteLine("|''''',:x0XNNNNXXXNNNKl''',dXXXXK0d;''lKNNNXNNNXXNNX0x:,'''''|");
        Console.WriteLine("|'''''''':xKXNNNNXNNNKkooodOXNXXXXOdookXNNNNNXNNNX0x:,'''''''|");
        Console.WriteLine("|''''''''',:xKXNNNNNNXNNXOOKKOxxkKKOOXXNNNNNNNXXKx:,'''''''''|");
        Console.WriteLine("|''''''''''',:xKXNNXXNNNKo;::,'';c:;oKNXNNNXNXKxc,'''''''''''|");
        Console.WriteLine("|''''''''''''',cxKXNNXXNKl''',:ldd:'lKNXXNXXKxc,'''''''''''''|");
        Console.WriteLine("|''''''''''''''',cxKXNXNKl'':dxxo;''lKXXNXKxc,'''''''''''''''|");
        Console.WriteLine("|''''''''''''''''',cxKXNKl,lxo;,''''oKNXKxc,'''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''',cxKXOoc;''''';oOXKxc,'''''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''''',cOXXOo;'';oOXXOc,'''''''''''''''''''''|");
        Console.WriteLine("|'''''''''''''''''''''':kXNXXOxxOXNNXk:''''''''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''''',oOKNXXNNXNNNNKOo,'''''''''''''''''''''|");
        Console.WriteLine("|'''''''''''''''''''''',lkKXNNNXNNXKkl,''''''''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''''''',;lkKNNXNXkl;,'''''''''''''''''''''''|");
        Console.WriteLine("|'''''''''''''''''''''''''',lddddl,''''''''''''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''|");
        Console.WriteLine("|''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''|");
        Console.WriteLine("*------------------------------------------------------------*");
      }
    }
}