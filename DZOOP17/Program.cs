using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP17
{
    class Shop
    {
        private List<Product> _goods;

        public event Action GoodsArrived;

        public Shop() 
        {
            _goods = new List<Product>();
        }

        public void SendGoods(string name, int price)
        {
            _goods.Add(new Product(name, price));
            GoodsArrived?.Invoke();
        }
    }

    class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    class Client
    {
        public Client(Shop shop)
        {
            shop.GoodsArrived += Message;
        }

        public void Message()
        {
            Console.WriteLine("Товар пришел");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Client client = new Client(shop);

            shop.SendGoods("Огурец",15);

            Console.ReadKey();
        }
    }
}
