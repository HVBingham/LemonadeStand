using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        string Name;
        Inventory PInventory;
        double Wallet;
        double TotalProfit;
     
       

        public Player()
        {
            PInventory  = new Inventory();
            Wallet = 20.00;
            TotalProfit = 0;
            PInventory.Cups = 0;
            PInventory.Lemons = 0;
            PInventory.Ice = 0;
            PInventory.CupsOfSugar = 0;

        }
        public string GetPlayerName()
        {
            Console.WriteLine("Please input your name");
            Name = Console.ReadLine();
            return Name;
        }
        public int PurchaseCups(Store store)
        {
           PInventory.Cups = store.PurchaseCups();
            return PInventory.Cups;

        }
        public int PurchaseLemons(Store store)
        {
            PInventory.Lemons = store.PurchaseLemons();
            return PInventory.Lemons;

        }
        public int PurchaseSugar(Store store)
        {
            PInventory.CupsOfSugar = store.PurchaseSugar();
            return PInventory.CupsOfSugar;
        }
        public int PurchaseIce(Store store)
        {
            PInventory.Ice = store.PurchaseIce();
            return PInventory.Ice;

        }
        





    }
}
