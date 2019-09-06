using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public int Cups;
        public int Ice;
        public int Lemons;
        public int CupsOfSugar;


        public Store()
        {


        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the store! Here you can buy all of the things you will need for your lemonade stand.");
        }
        public void PurchaseCups(Inventory inventory)
        {
            Console.WriteLine("First please choose an amount of cups you would like to buy." +"\n" +"Reminder it's a good idea to stock up on lots of cups since they never go bad.");
            Console.WriteLine("25 Cups for $0.99" + "\n" + "50 Cups for $1.75" + "\n" + "100 Cups for $3.08");
            Console.WriteLine("Write the number of cups you would like to purchase." +"\n" +"Input '25' , '50' , '100'");
           int cups = int.Parse(Console.ReadLine());
            //int cups= ValidateCups(Cups);
            inventory.Cups += cups;
           


        }
        //public int ValidateCups(int cups)
        //{
        //    switch (cups)
        //    {
        //        case 25:
        //            return cups;
        //            break;
        //        case 50:
        //            return cups;
        //            break;
        //        case 100:
        //            return cups;
        //            break;
        //        default:
        //            Console.WriteLine("Please pick a vaild cup amount");
        //            return PurchaseCups();
        //            break;
        //    }

        //}
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
            Console.WriteLine("Now it's time to buy ice." +"\n" +" Please choose the amount of ice cubes you would like to buy." +"\n" +" Reminder that your ice will melt at the end of everyday." +"\n" +" You will need to puchase new ice EVERYDAY!");
            Console.WriteLine("100 ice cubes for $0.79" + "\n" + "250 ice cubes for $2.08" + "\n" + "500 ice cubes for $3.62");
            Console.WriteLine("Write the number of Ice cubes you would like to purchse." +"\n" +"Input either '100', '250', '500'");
           int cubes = int.Parse(Console.ReadLine());
            //int cubes = ValidateIce(Ice);
               inventory.Ice += cubes;
         
        }
        //public int ValidateIce(int ice)
        //{
        //    switch (ice)
        //    {
        //        case 100:
        //            return ice;
        //            break;
        //        case 250:
        //            return ice;
        //            break;
        //        case 500:
        //            return ice;
        //            break;
        //        default:
        //            Console.WriteLine("Please input a valid Ice amount");
        //            return PurchaseIce();
        //            break;
        //    }
        //}

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
            Console.WriteLine("Time to buy cups of sugar." +"\n" +"Please choose the amount of sugar cups you would like to buy." +"\n" +"Reminder that your sugar can get bugs in it." +"\n"  +"You will want to only purchase the amount you will need per day.");
            Console.WriteLine("8 cups of sugar for $0.55" + "\n" + "20 cups of sugar for $1.52" + "\n" + "48 cups of sugar for $3.48");
            Console.WriteLine("Write the cups of sugar you would like to purchse." +"\n" +"Input either '8', '20', '48'");
            int sugar = int.Parse(Console.ReadLine());
            //int sugar = ValidateSugar(CupsOfSugar);
             inventory.CupsOfSugar+=sugar;
        }

        //public int ValidateSugar(int sugar)
        //{
        //    switch (sugar)
        //    {
        //        case 8:
        //            return CupsOfSugar;
        //            break;
        //        case 20:
        //            return CupsOfSugar;
        //            break;
        //        case 48:
        //            return CupsOfSugar;
        //            break;
        //        default:
        //            Console.WriteLine("Please input a valid Sugar amount.");
        //            return PurchaseSugar();
        //            break;
        //    }
        //}

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

            Console.WriteLine("Time to buy all the lemons." +"\n" +"Please choose the amount of lemons you would like to buy." +"Reminder that lemons will go bad." +"\n"  +"You will want to only purchase the amount you need per day.");
            Console.WriteLine("10 lemons for $0.59" + "\n" + "30 lemons for $2.39" + "\n" + "75 lemons $4.24");
            Console.WriteLine("Write the amount of lemons you would like to purchse." +"\n" +"Input either '10', '30', '75'");
            int lemons = int.Parse(Console.ReadLine());
            inventory.Lemons += lemons;
            
        }
        //public int ValidateLemons()
        //{
        //    switch (Lemons)
        //    {
        //        case 10:
        //            return Lemons;
        //            break;
        //        case 30:
        //            return Lemons;
        //            break;
        //        case 75:
        //            return Lemons;
        //            break;
        //        default:
        //            Console.WriteLine("Please input a valid lemon amount.");
        //            return PurchaseLemons();
        //            break;
        //    }
        //}
        public double priceforlemons(int lemon)
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
