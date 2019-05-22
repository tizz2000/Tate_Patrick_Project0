using System;
using System.Collections.Generic;

namespace VegPizzaData.data
{
    public partial class Customer
    {
        public Customer()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
