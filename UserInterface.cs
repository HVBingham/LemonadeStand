using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        string LemonadeStandName;
        Player PlayerOne;

        public UserInterface()
        {
            PlayerOne = new Player();
            
          
        }
        public string StandName()
        {
            Console.WriteLine("Please enter the name of you lemonade stand");
            LemonadeStandName = Console.ReadLine();
            return LemonadeStandName;
        }
        public void NeedToGOToStore()
        {
            Console.WriteLine("Do you need to go to the Walmart to pick up supplies today?");
            String userAnswer = Console.ReadLine();
            if (userAnswer=="yes")
            {
               VistStore();
            }
         
        }
        public void VistStore()
        {
            Store Walmart = new Store();
            Walmart.DisplayWelcome();
            PlayerOne.PurchaseCups(Walmart);
            Console.Clear();
            PlayerOne.PurchaseLemons(Walmart);
            Console.Clear();
            PlayerOne.PurchaseSugar(Walmart);
            Console.Clear();
            PlayerOne.PurchaseIce(Walmart);
            Console.Clear();
        }




    }
}
