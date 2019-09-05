using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string Name;
        Inventory PInventory;
        public double Wallet;
        public double TotalProfit;
        public int Cups;
        public int Lemons;
        public int Ice;
        public int CupsOfSugar;
     
       

        public Player()
        {
            PInventory  = new Inventory();
            Wallet = 20.00;
            TotalProfit = 0;
            Cups = 0;
            Lemons = 0;
            Ice = 0;
            CupsOfSugar = 0;

        }
        public int InventoryToPlayer(int item, int inventory)
        {
            item = inventory;
            return item;
        }
        public void PushToInvenotry()
        {
            InventoryToPlayer(Cups, PInventory.Cups);
            InventoryToPlayer(Lemons, PInventory.Lemons);
            InventoryToPlayer(Ice, PInventory.Lemons);
            InventoryToPlayer(CupsOfSugar, PInventory.CupsOfSugar);

        }
        public string GetPlayerName()
        {
            Console.WriteLine("Please input your name");
            Name = Console.ReadLine();
            return Name;
        }
        public int PurchaseCups(Store store)
        {
            Cups = store.PurchaseCups();
            return Cups;

        }
        public int PurchaseLemons(Store store)
        {
            Lemons = store.PurchaseLemons();
            return Lemons;

        }
        public int PurchaseSugar(Store store)
        {
           CupsOfSugar = store.PurchaseSugar();
            return CupsOfSugar;
        }
        public int PurchaseIce(Store store)
        {
            Ice = store.PurchaseIce();
            return Ice;

        }
        





    }
}
