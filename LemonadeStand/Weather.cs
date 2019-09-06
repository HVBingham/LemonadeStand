using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class  Weather
    {
        public List<string> SkyClearity;
        public  string clearity;
        public int foreCastedTemp;
        public int actualTemp;

        

        public Weather()
        {
            SkyClearity= new List<string>();
            SkyClearity.Add("Sunny");
            SkyClearity.Add("OverCast");
            SkyClearity.Add("Rainy");
            SkyClearity.Add("Cloudy");
            

            


        }
       
        public int FindHeat()
        {
            Random Tempurature = new Random();
           foreCastedTemp= Tempurature.Next(50,100);
            return foreCastedTemp;
          
            


        }
        public string FindClearity()
        {
            Random clearity = new Random();
            int i = clearity.Next(SkyClearity.Count);
            string FinalClearity = SkyClearity[i];
            return FinalClearity;

        }
        public string ForecastedClearity()
        {
            clearity = FindClearity();
            return clearity;
        }
       











    }
}
