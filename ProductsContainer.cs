using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnic02
{
    class ProductsContainer
    {
        private Dictionary<Good, int> _products = new Dictionary<Good, int>();

        public IEnumerable<KeyValuePair<Good, int>> GetProducts()
        {
            return _products.AsEnumerable();
        }

        public void Add(Good good, int count)
        {
            if (GoodValueChek(good))
            {
                if (CountValueChek(count))
                {
                    if (_products.ContainsKey(good))
                        _products[good] += count;
                    else
                        _products.Add(good, count);
                }
            }
        }

        public void RemoveKey(Good good)
        {
            if (GoodValueChek(good))
            {
                if (_products.ContainsKey(good))
                    _products.Remove(good);
                else
                    throw new KeyNotFoundException();
            }
        }

        public void Remove(Good good, int count)
        {
            if (CountValueChek(count))
                if (CanRemove(good, count))
                    _products[good] -= count;
        }

        public bool CanRemove(Good good, int count)
        {
            if (CountValueChek(count))
                if (GoodValueChek(good))
                    if (_products.ContainsKey(good))
                        if (_products[good] >= count)
                            return true;
                        else
                            throw new ArgumentOutOfRangeException();

            return false;
        }

        private bool GoodValueChek(Good good)
        {
            if (good == null)
                throw new NullReferenceException();

            if (string.IsNullOrEmpty(good.Id))
                throw new KeyNotFoundException();

            return true;
        }

        private bool CountValueChek(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            return true;
        }
    }
}
