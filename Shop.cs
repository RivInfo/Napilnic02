using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnic02
{
    class Shop
    {
        private Warehouse _warehouse;
        private Cart _cart;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void GoodToCart(Good good, int count)
        {
            if(_warehouse.CanRemove(good, count))
                _cart.Add(good, count);
        }

        public Cart Cart()
        {
            if (_cart == null)
                _cart = new Cart();

            return _cart;
        }

        public void PrintAllGoods()
        {
            foreach (KeyValuePair<Good, int> item in _warehouse.GetProducts())
            {
                Console.WriteLine($"{item.Key.Id}: {item.Value}");
            }
        }
    }
}
