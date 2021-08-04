using Entities.Concrete.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.Helpers
{
    public interface ICartSessionHelper
    {
        void SetToCart(string key, Cart cart);
        Cart GetCart(string key);
        void RemoveCart();
    }
}
