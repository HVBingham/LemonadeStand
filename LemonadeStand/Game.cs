using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        UserInterface User;
        List<Day> week;
        
      

        public Game()
        {
            week = new List<Day>();
            User = new UserInterface();
           
          
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand Game!");
            Console.WriteLine("The goal is to make as much money as possible by selling lemonade at your lemonade stand.");
            Console.WriteLine("You will need to go to the store to buy supplies. Set your recipe each day based on the forecasted weather conditions.");
            Console.WriteLine("You will also need to set the price of you lemonade everyday based upon the weather condtions.");
            Console.WriteLine("At the end you will see how much money your made or lost. Press enter to continue.");
            Console.ReadLine();
            
        }

        public void RunGame()
        {
            DisplayRules();
            Console.Clear();
            int lengthOfWeek = 7;
            User.UserName();
            User.StandName();
            Console.Clear();
                for (int i = 0; i < lengthOfWeek; i++)
                {
                week.Add(new Day());
                User.DisplayDayForecast(week[0]);  
                User.NeedToGOToStore();



                }

            

        }
       



    }
}
