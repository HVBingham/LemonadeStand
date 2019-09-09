using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        
        public int buyPercentage;
      

        public Customer()
        {
           
            buyPercentage = 0;
        }
      
      
        public void ChanceOfSale(Day day)
        {
            int heat = day.actualTemp;
            Random Chance = new Random();

            if (heat >= 90)
            {
                buyPercentage = Chance.Next(75, 100);
            }
            else if (heat >= 80)
            {
                buyPercentage = Chance.Next(55, 75);
            }
            else if (heat >= 70)
            {
                buyPercentage = Chance.Next(35, 55);
            }
            else if (heat <= 60)
            {
                buyPercentage = Chance.Next(15, 35);
            }
            

        }
        



    }



}
