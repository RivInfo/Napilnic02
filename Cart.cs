using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnic02
{
    class Cart : ProductsContainer
    {
        public Order Order(Warehouse warehouse)
        {
            Order order = new Order(GetProducts());
            order.Pay(warehouse);
            return order;
        }

        public void PrintGoods()
        {
            Console.WriteLine("В корзине:");
            foreach (KeyValuePair<Good, int> item in GetProducts())
            {
                Console.WriteLine($"{item.Key.Id}: {item.Value}");
            }
        }
    }
}
