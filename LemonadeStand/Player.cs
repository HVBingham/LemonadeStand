using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Inventory PInventory;
        public double Wallet;
        public double TotalProfit;
        public string standName;




        public Player()
        {
            PInventory  = new Inventory();
            Wallet = 20.00;
            TotalProfit = 0;

        }
    
        
        public string GetPlayerName()
        {

            UserInterface.UserName();
            name = Console.ReadLine();
            return name;
        }
        public string GetStandName()
        {
            UserInterface.StandName(name);
            standName = Console.ReadLine();
            return standName;
        }

        public void PurchaseItems(Store store)
        {
            store.PurchaseCups(PInventory);
            Console.Clear();
            store.PurchaseIce(PInventory);
            Console.Clear();
            store.PurchaseLemons(PInventory);
            Console.Clear();
            store.PurchaseSugar(PInventory);
            Console.Clear();
        }
        public void DisplayItems()
        {
            UserInterface.DisplayInventoryItems(PInventory);
        }
        
          




    }
}
