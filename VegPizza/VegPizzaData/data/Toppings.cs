using System;
using System.Collections.Generic;

namespace VegPizzaData.data
{
    public partial class Toppings
    {
        public int ToppingsId { get; set; }
        public string Tomatoes { get; set; }
        public string Onions { get; set; }
        public string Peppers { get; set; }
        public string Olives { get; set; }
        public string Mushrooms { get; set; }
        public string Pineapples { get; set; }
        public string Spinach { get; set; }
        public string Jalapenos { get; set; }
        public int? PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }
    }
}
