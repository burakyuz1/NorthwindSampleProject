using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Concrete.DomainModel
{
    public class Cart :IDomainModel
    {
        public Cart()
        {
            cartLines = new List<CartLine>();
        }
        public List<CartLine> cartLines { get; set; }
        //public decimal Total
        //{
        //    get
        //    {
        //        return cartLines.Sum(p => p.Quantity * p.Products.UnitPrice);
        //    }
        //}

    }
}
