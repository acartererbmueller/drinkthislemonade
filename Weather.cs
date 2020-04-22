using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {

        //Member Variables (HAS A)
        //public string mondaysWeatherForecast = "Monday is predicted to be sunny with a warm temperature.";
        //public string tuesdaysWeatherForecast = "Tuesday is predicted be windy with a warm tempearture.";
        //public string wednesdaysWeatherForecast = "Wednesday is predcited to cloudy with a cool temperature.";
        //public string thursdasysWeatherForecast = "Thursday is predicted to be raining with a cold temperature.";
        //public string fridaysWeatherForecast = "Friday is predicted to be clear skies with a hot temperature.";
        //public string saturdaysWeatherForecast = "Satuday will be hailing with cold temperature.";
        //public string sundaysWeatherForecast = "Sunday will be sunny with a cool temperature.";
        
       

        List<string> weatherConditions = new List<string>() { "Sunny", "Raining", "Cloudy", "Chilly", "Windy", "Clear Skies", "Hailing", };

        
        

        public string dailyCondition;
        public int dailyTemperature;

        //Constructor
        public Weather()
        {
            GetDailyCondition();
            GetDailyTemperature();
        }






        //Member Methods (CAN DO)


        //GetDailyCondition()
        public void GetDailyCondition()
        {
            //instantiating a object so we can use its .Next method
            Random rand = new Random();
            //getting a random number 0-6
            int randomIndex = rand.Next(0, 7);
            //using that randomindex as the index of our list to randomly grab one of those conditions
            dailyCondition = weatherConditions[randomIndex];
        }

        public void GetDailyTemperature()
        {
            Random rand = new Random();
            dailyTemperature = rand.Next(40, 95);


        }

        

    }
}
