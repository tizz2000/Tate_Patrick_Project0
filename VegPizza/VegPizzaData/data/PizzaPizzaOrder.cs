using System;
using System.Collections.Generic;

namespace VegPizzaData.data
{
    public partial class PizzaPizzaOrder
    {
        public int PizzaPizzaOrderId { get; set; }
        public int? PizzaOrderId { get; set; }
        public int? PizzaPizzaId { get; set; }

        public virtual PizzaOrder PizzaOrder { get; set; }
        public virtual Pizza PizzaPizza { get; set; }
    }
}
