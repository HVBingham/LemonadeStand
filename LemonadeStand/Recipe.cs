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
            Console.WriteLine("Now we are going to set our recipe for the day.");
            Console.WriteLine("How many lemons would you like to add per pitcher");
            lemons = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar per pitcher?");
            cupsOfSugar = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cubes of ice would you like to use per cup?");
            iceCubes = int.Parse(Console.ReadLine());
         }
           
        

    }
}
