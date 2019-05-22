using System;
using System.Collections.Generic;

namespace VegPizzaData.data
{
    public partial class PizzaOrder
    {
        public PizzaOrder()
        {
            PizzaPizzaOrder = new HashSet<PizzaPizzaOrder>();
        }

        public int PizzaOrderId { get; set; }
        public int? PizzaId { get; set; }
        public int? Storelocal { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Pizza Pizza { get; set; }
        public virtual Storelocal StorelocalNavigation { get; set; }
        public virtual ICollection<PizzaPizzaOrder> PizzaPizzaOrder { get; set; }
    }
}
