using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface { 
  

     
      
        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand Game!");
            Console.WriteLine("The goal is to make as much money as possible by selling lemonade at your lemonade stand.");
            Console.WriteLine("You will need to go to the store to buy supplies. Set your recipe each day based on the forecasted weather conditions.");
            Console.WriteLine("You will also need to set the price of you lemonade everyday based upon the weather condtions.");
            Console.WriteLine("At the end you will see how much money your made or lost. Press enter to continue.");
        }
        public static void UserName()
        {
            Console.WriteLine("Please input your name");
        }
        public static void WelcomeUser(string name)
        {
            Console.WriteLine("Welcome " +name );
        }
        public static void StandName(string name)
        {
            Console.WriteLine("Now " + name +" please enter the name of your lemonade stand");
        }   
        public static void ValidationDisplay()
        {
            Console.WriteLine("You must write an input");
        }

        public static void DisplaysWallet(Inventory inventory)
        {
            Console.WriteLine("Your wallet has $"+inventory.wallet);
        }
        public static void DisplayDayForecast(string clearity, int foreCastedTemp)
        {
            Console.WriteLine("The Forcasted Weather For the day is " + clearity + " and " + foreCastedTemp + " Degrees.");
        }
        public static void NeedForStore(string lemonadeStandName)
        {
            Console.WriteLine("Do you need to go to the Walmart to pick up supplies today for " + lemonadeStandName + "?");
        }
        public static void DisplayStoreWelcome()
        {
            Console.WriteLine("Welcome to the store! Here you can buy all of the things you will need for your lemonade stand.");
        }
        public static void CupPurchasingOptions()
        {
            Console.WriteLine("First please choose an amount of cups you would like to buy." + "\n" + "Reminder it's a good idea to stock up on lots of cups since they never go bad.");
            Console.WriteLine("25 Cups for $0.99" + "\n" + "50 Cups for $1.75" + "\n" + "100 Cups for $3.08");
            Console.WriteLine("Write the number of cups you would like to purchase." + "\n" + "Input '25' , '50' , '100' or '0'");
        }
        public static void IcePurchasingOptions()
        {
            Console.WriteLine("Now it's time to buy ice." + "\n" + " Please choose the amount of ice cubes you would like to buy." + "\n" + " Reminder that your ice will melt at the end of everyday." + "\n" + " You will need to puchase new ice EVERYDAY!");
            Console.WriteLine("100 ice cubes for $0.79" + "\n" + "250 ice cubes for $2.08" + "\n" + "500 ice cubes for $3.62");
            Console.WriteLine("Write the number of Ice cubes you would like to purchse." + "\n" + "Input either '100', '250', '500' or '0'");
        }
        public static void SugarPurchasingOptions()
        {
            Console.WriteLine("Time to buy cups of sugar." + "\n" + "Please choose the amount of sugar cups you would like to buy." + "\n" + "Reminder that your sugar can get bugs in it." + "\n" + "You will want to only purchase the amount you will need per day.");
            Console.WriteLine("8 cups of sugar for $0.55" + "\n" + "20 cups of sugar for $1.52" + "\n" + "48 cups of sugar for $3.48");
            Console.WriteLine("Write the cups of sugar you would like to purchse." + "\n" + "Input either '8', '20', '48' or '0'");
        }
        public static void LemonPurchasingOptions()
        {
            Console.WriteLine("Time to buy all the lemons." + "\n" + "Please choose the amount of lemons you would like to buy." + "Reminder that lemons will go bad." + "\n" + "You will want to only purchase the amount you need per day.");
            Console.WriteLine("10 lemons for $0.59" + "\n" + "30 lemons for $2.39" + "\n" + "75 lemons $4.24");
            Console.WriteLine("Write the amount of lemons you would like to purchse." + "\n" + "Input either '10', '30', '75' or '0'");
        }
        
        public static void RecipeStepOne()
        {
            Console.WriteLine("Now we are going to set our recipe for the day.");
            Console.WriteLine("How many lemons would you like to add per pitcher");
        }
        public static void RecipeStepTwo()
        {
            Console.WriteLine("How many cups of sugar per pitcher?");
        }
        public static void RecipeStepThree()
        {
            Console.WriteLine("How many cubes of ice would you like to use per cup?");
        }
        public static void DisplayActualWeather(int actualTemp, string clearity)
        {
            Console.WriteLine("It's " + actualTemp + " degrees and " + clearity);
        }
        public static void DisplayInventoryItems (Inventory inventory)
        {
            Console.WriteLine(inventory.Cups +" Cups");
            Console.WriteLine(inventory.Lemons +" Lemons");
            Console.WriteLine(inventory.CupsOfSugar +" Cups of Sugar");
            Console.WriteLine(inventory.Ice +" Ice");
        }
        public static void CupsPrice()
        {
            Console.WriteLine("How much would you like to charge per cup for lemonade today?");
        }
        





    }
}
