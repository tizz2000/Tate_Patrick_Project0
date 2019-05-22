using System;
using System.Collections.Generic;

namespace VegPizzaData.data
{
    public partial class Storelocal
    {
        public Storelocal()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int StorelocalId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
