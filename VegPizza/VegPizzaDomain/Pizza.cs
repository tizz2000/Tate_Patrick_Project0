using System;
using System.Collections.Generic;
using System.Text;

namespace VegPizzaDomain
{
   
 class Pizza

    {
    public List<string> pizzasize = new List<string>()
    {
        "small","medium","large","xlarge"
    };
    public List<string> pizzacrust = new List<string>()
    {
        "glutenfree","flatbread","wheat"
    };
   public List<string> pizzasauce = new List<string>()
    {
        "redsauce","whitesauce","italiansauce"
    };
    public List<string> pizzatoppings = new List<string>()
    {
        "tomatoes","onions","peppers","olives","mushrooms","pineapples","spinach","jalapenos"
    };
    
        public string GetPizzaSize()
        {
            int counter = 0;
            while (counter < pizzasize.Count)
            {
                Console.WriteLine($"{counter + 1} {pizzasize[counter]}");
            }
            Console.WriteLine("please choose a size");
            string read = Console.ReadLine();
            int response = Convert.ToInt32(read);
            return pizzasize[response - 1];
        }
        public string GetPizzaCrust()
        {
            int counter = 0;
            while (counter<pizzacrust.Count)
            {
                Console.WriteLine($"{counter + 1} {pizzacrust[counter]}");
            }
            Console.WriteLine("please choose your crust");
            string read = Console.ReadLine();
            int response = Convert.ToInt32(read);
            return pizzacrust[response - 1];
        }
        public string GetPizzaSauce()
        {
            int counter = 0;
            while (counter < pizzasauce.Count)
            {
                Console.WriteLine($"{counter + 1} {pizzasauce[counter]}");
            }
            Console.WriteLine("please choose a sauce");
            string read = Console.ReadLine();
            int response = Convert.ToInt32(read);
            return pizzasauce[response - 1];
        }
        public List<string> GetPizzaToppings()
        {
            int counter = 0;
            string read;
            int response;
            List<string> ingredients = new List<string>();
            while (counter < pizzatoppings.Count)
            {
                Console.WriteLine($"{counter + 1} {pizzatoppings[counter]}");
            }
            Console.WriteLine("Please select two toppings.");
            for (int i = 0; i < 1; i++)
            {
                read = Console.ReadLine();
                response = Convert.ToInt32(read);
                ingredients.Add(pizzatoppings[response-1]);
            }
            while (ingredients.Count < 5)
            {
                Console.WriteLine("would you like to add another topping? 1 for yes and 2 for no");
                read = Console.ReadLine();
                response = Convert.ToInt32(read);
                if (response==1)
                {
                    read = Console.ReadLine();
                    response = Convert.ToInt32(read);
                    ingredients.Add(pizzatoppings[response - 1]);
                }
                else
                {
                    break;
                }
            }

            return ingredients;
        }

        public float PizzaCost(string size, string crust, List<string> toppings, string sauce)
        {
            float Cost = 0;
            if (size == "small")
            {
                Cost += 8.30f;
            }
            else if (size == "medium")
            {
                Cost += 9.10f;
            }
            else if (size == "large")
            {
                Cost += 10.10f;
            }
            else
            {
                Cost += 10.70f;
            }

            if (crust == "glutenfree")
            {
                Cost += 3.25f;
            }
            else if (crust == "flatbread")
            {
                Cost += 3.75f;
            }
            else
            {
                Cost += 4.25f;
            }

            if (sauce == "redsauce")
            {
                Cost += 2.20f;
            }
            else if (sauce =="whitesauce")
            {
                Cost += 2.60f;
            }
            else
            {
                Cost += 3.0f;
            }
            return Cost;
        }
    }    
    

}
