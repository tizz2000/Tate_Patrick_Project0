using System;
using System.Collections.Generic;
using System.Text;
using VegPizzaDomain;

namespace VegPizzaCient
{
    class EnterAccount
    {
        public Customer InputCustomer(VegPizzaData.data.PizzaBoxContext db)
        {
            
            Console.WriteLine("Do you have an account? 1 for yes and 2 for no");
            string read = Console.ReadLine();
            int response=Convert.ToInt32(read);
            if (response == 1) //log in
            {
                return new Customer("", "", "", "", "", "", "", "", "", "");
            }
            else //create an account
            {
                string username = "";
                string password = "";
                string clientname = "";
                string clientaddress = "";
                string clientcity = "";
                string clientstate = "";
                string clientzipcode = "";
                string clientphone = "";
                string clientsetlocal = "";
                Console.WriteLine("Enter your UserName: ");
                username = Console.ReadLine();
                Console.WriteLine("enter your password: ");
                password = Console.ReadLine();
                Console.WriteLine("Enter your Name: ");
                clientname = Console.ReadLine();
                Console.WriteLine("enter your address:");
                clientaddress = Console.ReadLine();
                Console.WriteLine("enter city: ");
                clientcity = Console.ReadLine();
                Console.WriteLine("enter state: ");
                clientstate = Console.ReadLine();
                Console.WriteLine("enter zipcode: ");
                clientzipcode = Console.ReadLine();
                Console.WriteLine("enter phone: ");
                clientphone = Console.ReadLine();
                Console.WriteLine("enter your store location: ");
                clientsetlocal = Console.ReadLine();

                Customer cust = new Customer(username, password, clientname, clientaddress, clientcity, clientstate, clientzipcode,
                    clientzipcode, clientphone, clientsetlocal);

                db.Add<Customer>(cust);
                db.SaveChanges();

                return cust;
            }
        }

    }
}
