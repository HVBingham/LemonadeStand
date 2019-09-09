using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        
        public bool buyPercentage;
      

        public Customer()
        {
           
            buyPercentage = false;
        }
      
      
        public void ChanceOfSale(Day day)
        {
            int heat = day.actualTemp;
            Random Chance = new Random();

            if (heat >= 90)
            {
                buyPercentage = true;
                
            }
            else if (heat >= 80)
            {
                buyPercentage = true;
            }
            else if (heat >= 70)
            {
                buyPercentage = true;
            }
            else if (heat <= 60)
            {
                buyPercentage = true;
            }
            

        }
        



    }



}
