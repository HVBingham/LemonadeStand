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
        bool gameOver;
        
      

        public Game()
        {
            User = new UserInterface();
            gameOver = false;
          
        }
        public void DisplayRules()
        {


        }

        public void RunGame()
        {

        }
        //public bool IsGameOver(Player player)
        //{
        //    if(player.Wallet == 0)
        //    {
        //        Console.WriteLine(player.TotalProfit +"This is your total Profit for the game.");
        //        gameOver = true;
        //    }

        //}



    }
}
