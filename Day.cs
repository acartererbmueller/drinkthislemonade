﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //Member variables
        public Weather dailyWeather;
        public List<Customer> customers;

        //Constructor
        public Day()
        {
            dailyWeather = new Weather();
            customers = new List<Customer>();
        }




        //Member methods
        public void DisplayWeather()
        {
            Console.WriteLine("Weather:" + dailyWeather.dailyCondition + "and " + dailyWeather.dailyTemperature);
            
        }

        //Make a method that will use some if/else if to add Customers to the customers list -- add more if the weather is nicer!
        //What would it look like to add one single Customer to the list? Can you use a loop do this multiple times?

    }
}
