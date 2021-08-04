using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.cartLines.FirstOrDefault(p => p.Products.ProductID == product.ProductID);
            if (cartLine != null)
            {
                cartLine.Quantity++;
            }
            else
            {
                cart.cartLines.Add(new CartLine() { Products = product, Quantity = 1 });
            }
        }

   

        public List<CartLine> List(Cart cart)
        {
            return cart.cartLines;
        }

        public void RemoveFromCart(Cart cart, int id)
        {
            cart.cartLines.Remove(cart.cartLines.FirstOrDefault(p => p.Products.ProductID == id));
        }
    }
}
