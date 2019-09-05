using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        string userName;
        string LemonadeStandName;
        Player playerOne;

        public UserInterface()
        {
            playerOne = new Player();
            playerOne.Name = userName;
            
           
            
          
        }
        public string UserName()
        {
            userName = playerOne.GetPlayerName();
            return userName;
        }
        public string StandName()
        {
            Console.WriteLine(userName +" please enter the name of your lemonade stand");
            LemonadeStandName = Console.ReadLine();
            return LemonadeStandName;
        }
        public void NeedToGOToStore()
        {
            Console.WriteLine("Do you need to go to the Walmart to pick up supplies today for " +LemonadeStandName +"?");
            String userAnswer = Console.ReadLine();
            if (userAnswer=="yes")
            {
               VistStore();
            }
         //ToDo add and else statement so that they can play game with supplies they have.
        }
        public void VistStore()
        {
            Store Walmart = new Store();
            Walmart.DisplayWelcome();
            playerOne.PurchaseCups(Walmart);
            Console.Clear();
            playerOne.PurchaseLemons(Walmart);
            Console.Clear();
            playerOne.PurchaseSugar(Walmart);
            Console.Clear();
            playerOne.PurchaseIce(Walmart);
            Console.Clear();
        }
        




    }
}
