using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP7
{
    class Client
    {
        public string[] FoodBasket { get; private set; }
        public static Random Rnd { get; private set; }

        private int _money;

        public Client()
        {
            _money = 5000;
            FoodBasket = new string[Rnd.Next(5, 10 + 1)];
        }

        static Client()
        {
            Rnd = new Random();
        }

        public void FillFoodBasket(Magazin magazin)
        {
            for (int i = 0; i < magazin.Products.Length; i++)
            {
                for (int j = 0; j < FoodBasket.Length; j++)
                {
                    FoodBasket[j] = magazin.Products[i].Name;
                }
            }
        }

        public bool Pay(Magazin magazin, bool isPay)
        {
            if (_money >= magazin.TotalPrice)
            {
                _money -= magazin.TotalPrice;
            }
            else
            {

            }

            return isPay;
        }
    }

    class Magazin
    {
        public Product[] Products { get; private set; }
        public int TotalPrice { get; private set; }

        public Magazin()
        {
            Products = new Product[5];
            Products[0] = new Product("огурцец", 15);
            Products[1] = new Product("дошик", 45);
            Products[2] = new Product("помидор", 20);
            Products[3] = new Product("шоколадка", 100);
            Products[4] = new Product("молоко", 25);
        }

        public void CountTotalPrice(Client client)
        {
            for (int i = 0; i < client.FoodBasket.Length; i++)
            {
                for (int j = 0; j < Products.Length; j++)
                {
                    if (client.FoodBasket[i] == Products[j].Name)
                    {
                        TotalPrice += Products[j].Price;
                    }
                }
            }
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
            Client[] clients = new Client[3];
            clients[0] = new Client();
            clients[1] = new Client();
            clients[2] = new Client();

            Magazin magazin = new Magazin();

            bool isPay = true;

            for (int i = 0; i < clients.Length; i++)
            {
                clients[i].FillFoodBasket(magazin);
                magazin.CountTotalPrice(clients[i]);

                isPay = clients[i].Pay(magazin, isPay);

                if (isPay == true)
                {
                    Console.WriteLine("Покупка прошла успешно");
                }
            }

            Console.ReadKey();
        }
    }
}
