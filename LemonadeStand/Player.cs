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
 
     
       

        public Player()
        {
            PInventory  = new Inventory();
            Wallet = 20.00;
            TotalProfit = 0;

        }
    
        
        public string GetPlayerName()
        {
            Console.WriteLine("Please input your name");
            Name = Console.ReadLine();
            return Name;
        }
    
        public void PurchaseItems(Store store)
        {
            store.PurchaseCups(PInventory);
            store.PurchaseIce(PInventory);
            store.PurchaseLemons(PInventory);
            store.PurchaseSugar(PInventory);
        }





    }
}
