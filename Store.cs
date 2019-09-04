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
            Console.WriteLine("Welcome to the store! Here you can buy all of the things you will need for your lemonade stande.");
        }
        public int PurchaseCups()
        {
           
            Console.WriteLine("First please choose an amount of cups you would like to buy. Reminder it's a good idea to stock up on lots of cups since they never go bad.");
            Console.WriteLine("25 Cups for $0.99" +"\n" +"50 Cups for $1.75" +"\n" +"100 Cups for $3.08");
            Console.WriteLine("Write the number of cups you would like to purchase. Input '25' , '50' , '100'");
            Cups = int.Parse(Console.ReadLine());
            switch (Cups)
            {
                case 25:
                    return Cups;
                    break;
                case 50:
                    return Cups;
                    break;
                case 100:
                    return Cups;
                    break;
                default:
                    Console.WriteLine("Please pick a vaild cup amount");
                    return PurchaseCups();
                    break;
            }         
        }
        public double PriceForCups()
        {
            double PaperCups;
            switch (Cups)
            {
                case 25:
                    PaperCups = .99;
                    return PaperCups;
                    break;
                case 50:
                    PaperCups = 1.75;
                    return Cups;
                    break;
                case 100:
                    PaperCups = 3.08;
                    return PaperCups;
                    break;
                default:
                    Console.WriteLine("Please pick a vaild cup amount");
                    return PurchaseCups();
                    break;
            }
        }
        public double PurchaseIce()
        {
            Console.WriteLine("Now it's time to buy ice. Please choose the amount of ice cubes you would like to buy. Reminder that your ice will melt at the end of everyday. You will need to puchase new ice EVERYDAY!");
            Console.WriteLine("100 ice cubes for $0.79" + "\n" + "250 ice cubes for $2.08" +"\n" +"500 ice cubes for $3.62");
            Console.WriteLine("Write the number of Ice cubes you would like to purchse. Input either '100', '250', '500'");
            Ice = int.Parse(Console.ReadLine());
            switch (Ice)
            {
                case 100:
                    return Ice;
                    break;
                case 250:
                    return Ice;
                    break;
                case 500:
                    return Ice;
                    break;
                default:
                    Console.WriteLine("Please input a valid Ice amount");
                    return PurchaseIce();
                    break;
            }
        }
        public double PriceForIce()
        {

            double ice;
            switch (Ice)
            {
                case 100:
                    ice = .79;
                    return ice;
                    break;
                case 250:
                    ice = 2.08;
                    return ice;
                    break;
                case 500:
                    ice = 3.62;
                    return ice;
                    break;
                default:
                    Console.WriteLine("Please input a valid Ice amount");
                    return PurchaseIce();
                    break;
            }
        }
        public int PurchaseSugar()
        {
            Console.WriteLine("Time to buy cups of sugar. Please choose the amount of sugar cups you would like to buy. Reminder that your sugar can get bugs in it. You will want to only purchase the amount you will need per day.");
            Console.WriteLine("8 cups of sugar for $0.55" + "\n" + "20 cups of sugar for $1.52" + "\n" + "48 cups of sugar for $3.48");
            Console.WriteLine("Write the cups of sugar you would like to purchse. Input either '8', '20', '48'");
            CupsOfSugar = int.Parse(Console.ReadLine());
            switch (CupsOfSugar)
            {
                case 8:
                    return CupsOfSugar;
                    break;
                case 20:
                    return CupsOfSugar;
                    break;
                case 48:
                    return CupsOfSugar;
                    break;
                default:
                    Console.WriteLine("Please input a valid Sugar amount.");
                    return PurchaseSugar();
                    break;
            }
        }
        public double PriceForSugar()
        {
            double Sugar;
            switch (CupsOfSugar)
            {
                case 8:
                    Sugar = .55;
                    return Sugar;
                    break;
                case 20:
                    Sugar = 1.52;
                    return Sugar;
                    break;
                case 48:
                    Sugar = 3.48;
                    return Sugar;
                    break;
                default:
                    Console.WriteLine("Please input a valid Sugar amount.");
                    return PurchaseSugar();
                    break;
            }

        }
        public int PurchaseLemons()
        {
            Console.WriteLine("Time to buy all the lemons. Please choose the amount of lemons you would like to buy. Reminder that lemons will go bad. You will want to only purchase the amount you need per day.");
            Console.WriteLine("10 lemons for $0.59" + "\n" + "30 lemons for $2.39" + "\n" + "75 lemons $4.24");
            Console.WriteLine("Write the amount of lemons you would like to purchse. Input either '10', '30', '75'");
            Lemons = int.Parse(Console.ReadLine());
            switch (Lemons)
            {
                case 10:
                    return Lemons;
                    break;
                case 30:
                    return Lemons;
                    break;
                case 75:
                    return Lemons;
                    break;
                default:
                    Console.WriteLine("Please input a valid lemon amount.");
                    return PurchaseLemons();
                    break;
            }
        }
        public double PriceForLemons()
        {
            double lemons;
            switch (Lemons)
            {
                case 10:
                    lemons = .59;
                    return lemons;
                    break;
                case 30:
                    lemons = 2.39;
                    return lemons;
                    break;
                case 75:
                    lemons = 4.24;
                    return lemons;
                    break;
                default:
                    Console.WriteLine("Please input a valid lemon amount.");
                    return PurchaseLemons();
                    break;
            }
        }
        public double DeductPayment(double item, double wallet)
        {
            //double WalletTotal;
            if (wallet >= item)
            {
                wallet -= item;
                return wallet;

            }
            else
            {
                Console.WriteLine("You don't have enought money to buy this item.");
                return item;
            }

        }
        public void DisplayTotals()
        {
            Console.WriteLine(Lemons + "Lemons");
            Console.WriteLine(Cups + "cups");
            Console.WriteLine(CupsOfSugar + "Cups of Sugar");
            Console.WriteLine(Ice + "Cubes of Ice");
            Console.WriteLine("You now have $" + Wallet + ". Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void GiveEyesABreak()
        {
            Console.ReadLine();
            Console.Clear();
        }
        public double RunStore()
        {
            Player PlayerOne = new Player();
            double Wallet = PlayerOne.Wallet;
            DisplayTotals();
            DisplayWelcome();

            GiveEyesABreak();

            PurchaseCups();
            Wallet = DeductPayment(PriceForCups(), Wallet);
            Console.Clear();

            DisplayTotals();

            PurchaseLemons();
            Wallet = DeductPayment(PriceForLemons(), Wallet);
            Console.Clear();

            DisplayTotals();

            PurchaseIce();
            Wallet =  DeductPayment(PriceForIce(), Wallet);
            Console.Clear();

            DisplayTotals();

            PurchaseSugar();
            Wallet = DeductPayment(PriceForSugar(), Wallet);
            Console.ReadLine();
            Console.Clear();

            DisplayTotals();
            return Wallet;




        }




    }
 
}
