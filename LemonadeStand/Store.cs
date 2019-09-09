using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public int cups;
        public int ice;
        public int lemons;
        public int sugar;


        public Store()
        {


        }

     
        public void PurchaseCups(Inventory inventory)
        {
            UserInterface.CupPurchasingOptions();
            cups = int.Parse(Console.ReadLine());
            ValidateCups(inventory);
            inventory.Cups += cups;
            double cupsPrice = PriceForCups(cups);
            if (inventory.wallet >= cupsPrice)
            {
             inventory.wallet = DeductPayment(cupsPrice, inventory.wallet);
            }
            else
            {
                PurchaseCups(inventory);
            }


           


        }
        public void ValidateCups(Inventory inventory)
        {
            switch (cups)
            {
                case 25:
                    cups=25;
                    break;
                case 50:
                    cups=50;
                    break;
                case 100:
                    cups=100;
                    break;
                default:
                    Console.WriteLine("Please pick a vaild cup amount");
                    PurchaseCups(inventory);
                    break;
            }

        }
        public double PriceForCups(int cups)
        {
            double paperCups = 0;
            switch (cups)
            {
                case 25:
                    paperCups = .99;
                    break;
                case 50:
                    paperCups = 1.75;
                    break;
                case 100:
                    paperCups = 3.08;
                    break;
            }
            return paperCups;
        }
       
        public void PurchaseIce(Inventory inventory)
        {
            UserInterface.IcePurchasingOptions();
            int cubes = int.Parse(Console.ReadLine());
            ValidateIce(inventory);
            inventory.Ice += cubes;
            double icePrice = PriceForIce(cubes);
            if (inventory.wallet >= icePrice)
            {
                inventory.wallet = DeductPayment(icePrice, inventory.wallet);
            }
            else
            {
                PurchaseIce(inventory);
            }

        }
        public void ValidateIce(Inventory inventory)
        {
            switch (ice)
            {
                case 100:
                    ice = 100;
                    break;
                case 250:
                    ice = 250;
                    break;
                case 500:
                    ice = 500;
                    break;
                default:
                    Console.WriteLine("Please input a valid Ice amount");
                    PurchaseIce(inventory);
                    break;
            }
        }

        public double PriceForIce(int cubes)
        {
            double ice = 0;
            switch (cubes)
            {
                case 100:
                    ice = .79;
                    break;
                case 250:
                    ice = 2.08;
                    break;
                case 500:
                    ice = 3.62;
                    break;
            }
            return ice;
         }
        public void PurchaseSugar(Inventory inventory)
        {
            UserInterface.SugarPurchasingOptions();
            sugar = int.Parse(Console.ReadLine());
            ValidateSugar(inventory);
             inventory.CupsOfSugar+=sugar;
            double sugarPrice = PriceForSugar(sugar);
            if (inventory.wallet >= sugarPrice)
            {
                inventory.wallet = DeductPayment(sugarPrice, inventory.wallet);
            }
            else
            {
                PurchaseSugar(inventory);
            }
        }

        public void ValidateSugar(Inventory inventory)
        {
            switch (sugar)
            {
                case 8:
                    sugar = 8;
                    break;
                case 20:
                    sugar = 20;
                    break;
                case 48:
                    sugar = 48;
                    break;
                default:
                    Console.WriteLine("Please input a valid Sugar amount.");
                    PurchaseSugar(inventory);
                    break;
            }
        }

            public double PriceForSugar(int Sugar)
             {
                double sugar = 0;
                switch (Sugar)
                {
                    case 8:
                        sugar = .55;
                        break;
                    case 20:
                        sugar = 1.52;
                        break;
                    case 48:
                        sugar = 3.48;
                        break;
                }
                 return sugar;
            }
        public void PurchaseLemons(Inventory inventory)
        {

            UserInterface.LemonPurchasingOptions();
            lemons = int.Parse(Console.ReadLine());
            ValidateLemons(inventory);
            inventory.Lemons += lemons;
            double lemonsPrice = PriceForLemons(lemons);
            if (inventory.wallet >= lemonsPrice)
            {
                inventory.wallet = DeductPayment(lemonsPrice, inventory.wallet);
            }
            else
            {
                PurchaseLemons(inventory);
            }

        }
        public void ValidateLemons(Inventory inventory)
        {
            switch (lemons)
            {
                case 10:
                    lemons = 10;
                    break;
                case 30:
                    lemons = 30;
                    break;
                case 75:
                    lemons = 75;
                    break;
                default:
                    Console.WriteLine("please input a valid lemon amount.");
                    PurchaseLemons(inventory);
                    break;
            }
        }
        public double PriceForLemons(int lemon)
        {
            double lemons = 0;
            switch (lemon)
            {
                case 10:
                    lemons = .59;
                    break;
                case 30:
                    lemons = 2.39;
                    break;
                case 75:
                    lemons = 4.24;
                    break;
            }
            return lemons;
        }
      
        public double DeductPayment(double item, double wallet)
        {   
                
                wallet -= item;
            return wallet;

        }

    


    }
    
}
