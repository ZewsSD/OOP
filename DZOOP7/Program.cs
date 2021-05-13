using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP7
{
    class Client
    {
        private int _money;
        private string[] _products;

        public Client()
        {
            _money = 5000;
        }

        public void GiveAwayBasket(Magazin magazin)
        {

        }

        public void GetTotalPrice(Magazin magazin)
        {

        }
    }

    class Magazin
    {
        public Magazin()
        {
            Product[] products = { new Product("огурцец", 15), new Product("дошик", 45), new Product("помидор", 20), new Product("шоколадка", 100), new Product("молоко", 25) };
        }

        public void CountTotalPrice(Client client)
        {

        }
    }

    class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(string productName, int productPrice)
        {
            Name = productName;
            Price = productPrice;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
