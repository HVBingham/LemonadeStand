using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class  Weather
    {
        List<string> SkyClearity;
        public  string clearity;
        private int foreCastedTemp;
        

        public Weather()
        {
            SkyClearity= new List<string>();
            SkyClearity.Add("Sunny");
            SkyClearity.Add("OverCast");
            SkyClearity.Add("Rainy");
            SkyClearity.Add("Cloudy");
            

            


        }
        public int ForCastedTemp
          {
            get{
                return foreCastedTemp;
             }
           
          }
        public int FindHeat(int min, int max)
        {
            Random Tempurature = new Random();
            int RandomTemp = Tempurature.Next(min, max);
            return RandomTemp;
            


        }
        public string FindClearity()
        {
            Random clearity = new Random();
            int i = clearity.Next(SkyClearity.Count);
            string FinalClearity = SkyClearity[i];
            return FinalClearity;

        }
        //public string ForecastedClearity()
        //{
        //    clearity = FindClearity();
        //    return clearity;
        //}
        //public int ForecastedHeat()
        //{
        //    foreCastedTemp = FindHeat(50, 98);
        //    return foreCastedTemp;

        //}
       











    }
}
