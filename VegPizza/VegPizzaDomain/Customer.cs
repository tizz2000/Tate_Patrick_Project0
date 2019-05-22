using System;
using System.Collections;
using System.Collections.Generic;

namespace VegPizzaDomain
{
    public class Customer
    {
        List<Order> OrderHistory;
        string UserName;
        string PassWord;
        string ClientName;
        string ClientAddress;
        string ClientCity;
        string ClientState;
        string ClientCountry;
        string ClientZipcode;
        string ClientPhone;
        bool CountExist;
        string ClientSetLocal;
        public Customer(string UserName, string PassWord, string ClientName, string ClientAddress, string ClientCity, string ClientState, string ClientZipcode, string ClientPhone, string ClientSetLocal, string clientsetlocal)
        {
            OrderHistory = new List<Order>();
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.ClientName = ClientName;
            this.ClientAddress = ClientAddress;
            this.ClientCity = ClientCity;
            this.ClientState = ClientState;
            this.ClientZipcode = ClientZipcode;
            this.ClientPhone = ClientPhone;
            this.ClientSetLocal = ClientSetLocal;


        }
        Customer(string ClientName, string ClientAddress, string ClientPhone, string ClientSetLocal, List<Order> OrderHistory)
        {
            this.OrderHistory = OrderHistory;
            this.ClientName = ClientName;
            this.ClientAddress = ClientAddress;
            this.ClientPhone = ClientPhone;
            this.ClientSetLocal = ClientSetLocal;
            this.CountExist = true;


        }

    }
    
    
}
