using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player playerOne;
      public  List<Day> week;

        
      

        public Game()
        {
            playerOne = new Player();
            week = new List<Day>();
            
          
        }
     

        public void RunGame()
        {

            UserInterface.DisplayRules();
            Console.ReadLine();
            Console.Clear();
            int lengthOfWeek = 7;
            playerOne.GetPlayerName();
            UserInterface.WelcomeUser(playerOne.name);
            playerOne.GetStandName();
           
            Console.Clear();
                for (int i = 0; i < lengthOfWeek; i++)
                {
             
                    week.Add(new Day());
                    week[i].DisplayForCast();
                    week[i].NeedToGOToStore(playerOne.standName, playerOne);
                    UserInterface.DisplayInventoryItems(playerOne.PInventory);
                    UserInterface.DisplaysWallet(playerOne.PInventory);
                    foreach(Day day in week)
                     {
                        Console.WriteLine("Day " +i+1);
                     }
                    week[i].ActualWeather();
                    week[i].SetRecipe(playerOne.PInventory);
                    week[i].SetCupPrice();

                    week[i].HowManyCustomers();
                    UserInterface.DispalyDailyProfit(week[i]);


                
                    


                }

            

        }
       



    }
}
