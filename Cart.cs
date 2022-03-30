using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnic02
{
    class Cart : ProductsContainer
    {
        public string Paylink { get; private set; } = "Купить";

        public Good[] Order()
        {
            throw new NotImplementedException();
        }
    }
}
