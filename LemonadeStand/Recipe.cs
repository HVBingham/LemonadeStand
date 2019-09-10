using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int cups;
        public int lemons;
        public int cupsOfSugar;
        public int iceCubes;
         
        public Recipe()
        {
            
        }
        
        public void SetRecipe(Inventory inventory)
        {
            GetLemons(inventory);
            GetSugar(inventory);
            GetIce(inventory);
          
    
         }
        public void GetLemons(Inventory inventory)
        {
            UserInterface.RecipeStepOne();
            int lemon = int.Parse(Console.ReadLine());
            if(lemon <= inventory.Lemons)
            {
                lemons = lemon;
            }
            else
            {
                UserInterface.ValidationDisplay();
                GetLemons(inventory);
            }
        }
        public void GetSugar(Inventory inventory)
        {
            UserInterface.RecipeStepTwo();
            int sugar = int.Parse(Console.ReadLine());
            if (sugar <= inventory.CupsOfSugar)
            {
                sugar = cupsOfSugar;
            }
            else
            {
                UserInterface.ValidationDisplay();
                GetSugar(inventory);
            }

        }
        public void GetIce(Inventory inventory)
        {
            UserInterface.RecipeStepThree();
            int cubes = int.Parse(Console.ReadLine());
            if (cubes <= inventory.Ice)
            {
                iceCubes = cubes;
            }
            else
            {
                UserInterface.ValidationDisplay();
                GetIce(inventory);
            }
        }

           
        

    }
}
