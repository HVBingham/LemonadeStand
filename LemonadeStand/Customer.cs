using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int customers;
        public int buyPercentage;

        public Customer()
        {
            customers = 0;
            buyPercentage = 0;
        }
        public void HowManyCustomers(Day day)
        {
            string clearity = day.clearity;
           
            Random randomCustomers = new Random();
            switch (clearity)
            {
                case "Sunny":
                    customers = randomCustomers.Next(145, 200);
                    break;
                case "Overcast":
                    customers = randomCustomers.Next(125, 175);
                    break;
                case "Cloudy":
                    customers = randomCustomers.Next(80, 120);
                    break;
                case "Rainy":
                    customers = randomCustomers.Next(20, 70);
                    break;                 
            }

            
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
