using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnic02
{
    class Order : ProductsContainer 
    {
        public string Paylink { get; private set; }

        public Order(IEnumerable<KeyValuePair<Good, int>> goods) : base(goods)
        {
        }

        public void Pay(Warehouse warehouse)
        {
            if (GetProducts().Count() == 0)
                throw new ArgumentNullException();

            foreach (KeyValuePair<Good, int> item in GetProducts())
            {
                warehouse.Remove(item.Key, item.Value);
            }

            Paylink = "Ссылка на заказа";
        }
    }
}
