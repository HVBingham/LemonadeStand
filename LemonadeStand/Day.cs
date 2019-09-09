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
        double daysProfit;
        Weather currentWeather;
        double lemonadePrice;
        int foreCastedTemp;
        public string clearity;
        public int actualTemp;
         public List<Customer> customers;
      

        public Day()
        {
            customers = new List<Customer>();
            newRecipe = new Recipe();
            currentWeather = new Weather();
            daysProfit = 0;
           


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
            //ToDo add and else statement so that they can play game with supplies they have.
        }
        public void VistStore(Player player)
        {
            Store Walmart = new Store();
            UserInterface.DisplayStoreWelcome();
            player.PurchaseItems(Walmart);
        }



        public void SetRecipe()
        {
            newRecipe.SetRecipe();
        }

      
        public void SetCupPrice()
        {
            UserInterface.CupsPrice();
            lemonadePrice = double.Parse(Console.ReadLine());
        }
       public int ActualWeather()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(-3, 3);
            actualTemp = RandomNumber + foreCastedTemp;
            UserInterface.DisplayActualWeather(actualTemp, clearity);
            return actualTemp;

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
       
   










    }
}
