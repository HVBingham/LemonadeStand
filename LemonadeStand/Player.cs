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
        public double TotalProfit;
        public string standName;




        public Player()
        {
            PInventory  = new Inventory();
            TotalProfit = 0;

        }
    
        
        public string GetPlayerName()
        {

            UserInterface.UserName();
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                UserInterface.ValidationDisplay();
                GetPlayerName();
            }
            return name;
        }
        public string GetStandName()
        {
            UserInterface.StandName(name);
            standName = Console.ReadLine();
            if (string.IsNullOrEmpty(standName))
            {
                UserInterface.ValidationDisplay();
                GetStandName();
            }
            return standName;
        }

        public void PurchaseItems(Store store)
        {
            store.PurchaseCups(PInventory);
            Console.Clear();
            UserInterface.DisplaysWallet(PInventory);
            store.PurchaseIce(PInventory);
            Console.Clear();
            UserInterface.DisplaysWallet(PInventory);
            store.PurchaseLemons(PInventory);
            Console.Clear();
            UserInterface.DisplaysWallet(PInventory);
            store.PurchaseSugar(PInventory);
            Console.Clear();
            UserInterface.DisplaysWallet(PInventory);
            Console.Clear();
        }
      
        
          




    }
}
