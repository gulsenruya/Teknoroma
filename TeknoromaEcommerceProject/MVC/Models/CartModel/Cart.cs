using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.CartModel
{
    public class Cart
    {
        public Dictionary<Guid, CartItem> _cart = new Dictionary<Guid, CartItem>();

        public List<CartItem> MyCart
        {
            get
            {
                return _cart.Values.ToList();
            }
        }

        public void AddItem(CartItem item)
        {
            if (_cart.ContainsKey(item.ID))
            {
                _cart[item.ID].Quantity += 1;
                return;
            }
            _cart.Add(item.ID, item);
        }
        public Guid ShipperId { get; set; }
        public decimal ShipmentPrice { get; set; }
    }
}
