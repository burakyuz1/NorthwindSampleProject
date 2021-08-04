using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DomainModel
{
    public class CartLine : IDomainModel
    {
        public Product Products { get; set; }
        public int Quantity { get; set; }
    }
}
