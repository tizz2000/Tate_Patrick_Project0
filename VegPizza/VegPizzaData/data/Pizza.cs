using System;
using System.Collections.Generic;

namespace VegPizzaData.data
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
            PizzaPizzaOrder = new HashSet<PizzaPizzaOrder>();
            ToppingsNavigation = new HashSet<Toppings>();
        }

        public int PizzaId { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Toppings { get; set; }
        public int PizzaCount { get; set; }
        public decimal PizzaPrice { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrder { get; set; }
        public virtual ICollection<PizzaPizzaOrder> PizzaPizzaOrder { get; set; }
        public virtual ICollection<Toppings> ToppingsNavigation { get; set; }
    }
}
