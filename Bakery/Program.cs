using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery
{
    public class Program
    {
      public static void Main(){
        StartMenu();

      }

      private static void StartMenu(){
        Console.WriteLine("     Welcome to Pierre's Bakery     ");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread...........................$5|");
        Console.WriteLine("|Pastry..........................$2|");
        Console.WriteLine("|                                  |");
        Console.WriteLine("|Bread: B2G1 Free   Pastry: B2G1 $1|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        BuyBread();
      }
      private static void BuyBread()
      {
        Console.WriteLine("Please enter how many loaves of bread you would like to buy:");
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
        Console.WriteLine("Please enter how many pastries you would like to buy:");
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

        Console.WriteLine("Bread length:" + breadLength.ToString());

        string breadLine = "";
        string pastryLine = "";
        string totalLine = "";

        for(int i = 0; i < breadLength - checkOut[0].ToString().Length; i++){ breadLine += ".";}
        for(int i = 0; i < pastryLength - checkOut[1].ToString().Length; i++){ pastryLine += ".";}
        for(int i = 0; i< totalLength; i++){ totalLine += ".";}

        Console.WriteLine("Bread line:" + breadLine);
        
        Console.WriteLine("*----------------------------------*");//34
        Console.WriteLine("|             Reciept              |");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Bread x" + checkOut[0]  + breadLine + "$"+ buyBread.TotalCost.ToString() +".00|");
        Console.WriteLine("|Pastry x" + checkOut[1] +  pastryLine + "$"+ buyPastry.TotalCost.ToString() +".00|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|Total" + totalLine + "$"+ total.ToString() +".00|");
        Console.WriteLine("*----------------------------------*");
        Console.WriteLine("|        Glory To Arstotzka        |");
        Console.WriteLine("*----------------------------------*");
        string response = Console.ReadLine().ToUpper();
        if(response == "GLORY TO ARSTOTZKA" || "GLORY TO ARSTOTZKA!")
        {
          EasterEgg();
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