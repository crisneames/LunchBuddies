using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    public class Restaurant
    {
        public string name = "";
        

        private Restaurant(List<string> Restaurants) 
        {
            Restaurants.Add("Chuys");
            Restaurants.Add("AppleBee's");
            Restaurants.Add("Cheddars");
            Restaurants.Add("Slim Chicken");
            Restaurants.Add("McDonalds");

            Random randomGenerator = new Random();
            int num = randomGenerator.Next(Restaurants.Count);
            name = Restaurants[num];
            Console.WriteLine(name);
        }

    }
}
