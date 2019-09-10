using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        Recipe newRecipe;
        public double daysProfit;
        Weather currentWeather;
        double lemonadePrice;
        int foreCastedTemp;
        public string clearity;
        public int actualTemp;
        public List<Customer> customers;
        int pitcher;
      

        public Day()
        {
            customers = new List<Customer>();
            newRecipe = new Recipe();
            currentWeather = new Weather();
            daysProfit = 0;
            pitcher = 6;
           


        }
        public void DisplayForCast()
        {
            foreCastedTemp = currentWeather.FindHeat();
            clearity = currentWeather.FindClearity();
            UserInterface.DisplayDayForecast(clearity, foreCastedTemp);
        }
        public void NeedToGOToStore(string name, Player player)
        {
            UserInterface.NeedForStore(name);
            String userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "yes")
            {
                VistStore(player);
            }
            else if (string.IsNullOrEmpty(userAnswer))
            {
                UserInterface.ValidationDisplay();
                NeedToGOToStore(name, player);
            }
        }
        public void VistStore(Player player)
        {
            Store Walmart = new Store();
            UserInterface.DisplayStoreWelcome();
            player.PurchaseItems(Walmart);
        }

         public int ActualWeather()
         {
                    Random rnd = new Random();
                    int RandomNumber = rnd.Next(-3, 3);
                    actualTemp = RandomNumber + foreCastedTemp;
                    UserInterface.DisplayActualWeather(actualTemp, clearity);
                    return actualTemp;

         }

        public void SetRecipe(Inventory inventory)
        {
            newRecipe.SetRecipe(inventory);
        }

      
        public void SetCupPrice()
        {
            UserInterface.CupsPrice();
            lemonadePrice = double.Parse(Console.ReadLine());
        }
      
        

        public void HowManyCustomers()
        {
            int numberOfCustomers=0;
            Random randomCustomers = new Random();
            switch (clearity)
            {
                case "Sunny":
                    numberOfCustomers = randomCustomers.Next(145, 200);
                    break;
                case "Overcast":
                    numberOfCustomers = randomCustomers.Next(125, 175);
                    break;
                case "Cloudy":
                    numberOfCustomers = randomCustomers.Next(80, 120);
                    break;
                case "Rainy":
                    numberOfCustomers=randomCustomers.Next(20, 70);
                    break;
            }
            for(int i=0; i<numberOfCustomers; i++)
            {
                customers.Add(new Customer());
            }

        }
        public bool DidCustomerBuy()
        {
            bool didCustomerBuy = false;
            if (actualTemp >= 75)
            {
                if (lemonadePrice <= 50)
                {
                    didCustomerBuy = true;
                }
                else if (lemonadePrice > 50)
                {
                    didCustomerBuy = false;
                }
            }
            else if (actualTemp <= 75)
            {
                if (lemonadePrice > 50)
                {
                    didCustomerBuy = false;
                }
                else if (lemonadePrice <= 25)
                {
                    didCustomerBuy = true;
                }
            }
            return didCustomerBuy;
        }
    
        public void DeductRecipeFromInventory(Recipe recipe, Inventory inventory)
        {
            
            int purchasedcup = 1;

            bool customerBuysCup = false;
            customerBuysCup=DidCustomerBuy();

            if (customerBuysCup == true)
            {
                pitcher -= purchasedcup;
            }
        }
        public void CheckPitcher(Inventory inventory, Recipe recipe)
        {
            bool isPitcherEmpty;
            if (pitcher == 0)
            {
                isPitcherEmpty = true;
                if (isPitcherEmpty == true)
                {
                    RefillPitcher(inventory, recipe);

                }
            }
        }
       
        public void RefillPitcher(Inventory inventory, Recipe recipe)
        {
            inventory.Lemons -= recipe.lemons;
            inventory.CupsOfSugar -= recipe.cupsOfSugar;
            inventory.Cups -= pitcher;
            inventory.Ice -= (recipe.iceCubes * pitcher);
            pitcher = 6;
        }

         public void DaysProfitTotal(Inventory inventory, Recipe recipe)
         {
           
            

         }









    }
}
