using System;
using System.Collections.Generic;
using VegPizzaData.data;
using VegPizzaDomain;

namespace VegPizzaCient
{
    class Program
    {
        private static IEnumerable<string> sizeList;

        static void Main(string[] args)
        {
            using (var db = new PizzaBoxContext())
            {
                EnterAccount Ea = new EnterAccount();
                VegPizzaDomain.Customer user = Ea.InputCustomer(db);
            }
        }
    

          
        //    Customer user1 = LogIn();

            int PizzaCount;

        //    //PizzaType type = new PizzaType();

        //    //string size;
        //    //do {
        //    //    Console.WriteLine($"What size pizza: {type.sizeList[0]},{type.sizeList[1]}, {type.sizeList[2]}, {type.sizeList[3]}");
        //    //    size = Console.ReadLine()
        //    //} while (size != "Small" && size != "Medium" && size != "Large" && size != "X-Large");

        //    //Console.WriteLine($"what type of crust: {type.crustList[0]}, {type.crustList[1]}, {type.crustList[2]}");
        //    //Console.Read(type)
        //    // Console.WriteLine($"what type of sauce: {type.sauceList[0]}, {type.sauceList[1]}, {type.sauceList[2]}");
        //    //Console.WriteLine($"what are your toppings: {type.vegtoppingList[0]}, {type.vegtoppingList[1]}, {type.vegtoppingList[2]}")
            
        //}

            /*
        static VegPizzaDomain.Customer LogIn()
        {
                string ClientName = "";
                string ClientAddress = "";
                string ClientCity = "";
                string ClientState = "";
                string ClientCountry = "";
                string ClientZipcode = "";
                string ClientPhone = "";
                Console.WriteLine("are you a member? y/n: ");
                string LogInAnswer = Console.ReadLine();
                if (LogInAnswer == "y")
                {
                    Console.WriteLine("What's your User Name: ");
                    ClientName = Console.ReadLine();
                    Console.WriteLine("What's your address: ");
                    ClientAddress = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number: ");
                    ClientPhone = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter your Name: ");
                    ClientName = Console.ReadLine();
                    Console.WriteLine("enter your address:");
                    ClientAddress = Console.ReadLine();
                    Console.WriteLine("enter city: ");
                    ClientCity = Console.ReadLine();
                    Console.WriteLine("enter state: ");
                    ClientCity = Console.ReadLine();
                    Console.WriteLine("enter country: ");
                    ClientCountry = Console.ReadLine();
                    Console.WriteLine("enter zipcode: ");
                    ClientZipcode = Console.ReadLine();
                    Console.WriteLine("enter phone: ");
                    ClientPhone = Console.ReadLine();
                }

                //    Customer user = new Customer(ClientName, ClientAddress, ClientCity, ClientState, ClientCountry, ClientZipcode, ClientPhone);
                //    return user;
                //}
                //static Order ReceiveOrder()
                //{
                //    const int PizzaCount = 100;
                //    float CostCompute;
                //    const int LimitPizzaCount = 5000;
                //    float CostLimit;
                //    int pizzaorder;

                //    Console.WriteLine("what size pizza?: ");
                //    foreach (PizzaSize ps in Enum.GetValues (typeof(PizzaSize)) )
                //    {
                //        Console.WriteLine(ps);
                //    }
                //    Console.ReadLine();

                //     Console.WriteLine("what type of crust?: ");
                //     foreach (PizzaCrust pc in Enum.GetValues(typeof(PizzaCrust)))
                //     {
                //         Console.WriteLine(pc);
                //     }
                //     Console.ReadLine();

                //     Console.WriteLine("what type of sauce?: ");
                //     foreach (PizzaSauce psc in Enum.GetValues(typeof(PizzaSauce)))
                //     {
                //         Console.WriteLine(psc);
                //     }
                //     Console.ReadLine();

                //    return pizzaorder()
            }
            */
    }
}
    
