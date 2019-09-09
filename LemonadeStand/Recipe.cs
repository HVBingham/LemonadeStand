using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        int cups;
        int lemons;
        int cupsOfSugar;
        int iceCubes;
        
        public Recipe()
        {
            
        }
        
        public void SetRecipe()
        {
            UserInterface.RecipeStepOne();
            lemons = int.Parse(Console.ReadLine());
            UserInterface.RecipeStepTwo();
            cupsOfSugar = int.Parse(Console.ReadLine());
            UserInterface.RecipeStepThree();
            iceCubes = int.Parse(Console.ReadLine());
         }

           
        

    }
}
