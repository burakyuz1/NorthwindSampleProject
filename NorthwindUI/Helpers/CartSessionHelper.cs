using Entities.Concrete.DomainModel;
using Microsoft.AspNetCore.Http;
using NorthwindUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.Helpers
{
    public class CartSessionHelper : ICartSessionHelper
    {
        IHttpContextAccessor _httpContextAccesor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccesor)
        {
            _httpContextAccesor = httpContextAccesor;
        }

        public Cart GetCart(string key)
        {
            Cart cartToCheck = _httpContextAccesor.HttpContext.Session.GetObj<Cart>(key);
            if (cartToCheck == null)
            {
                SetToCart(key, new Cart());
                cartToCheck = _httpContextAccesor.HttpContext.Session.GetObj<Cart>(key);
            }
            return cartToCheck;
        }

        public void RemoveCart()
        {
            throw new NotImplementedException();
        }

        public void SetToCart(string key, Cart cart)
        {
            _httpContextAccesor.HttpContext.Session.SetObj(key, cart);
        }
    }
}
