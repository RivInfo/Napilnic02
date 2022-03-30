using System;

namespace Napilnic02
{
    class Program
    {
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Add(iPhone12, 10);
            warehouse.Add(iPhone11, 1);

            //Вывод всех товаров на складе с их остатком
            shop.PrintAllGoods();

            Cart cart = shop.Cart();
            shop.GoodToCart(iPhone12, 4);
            shop.GoodToCart(iPhone11, 3); //при такой ситуации возникает ошибка так, как нет нужного количества товара на складе

            //Вывод всех товаров в корзине
            cart.PrintGoods();


            Console.WriteLine(cart.Order(warehouse).Paylink);

            shop.GoodToCart(iPhone12, 9); //Ошибка, после заказа со склада убираются заказанные товары
        }
    }
}
