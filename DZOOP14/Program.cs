using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP14
{
    class CarService
    {
        public int Money { get; private set; }
        public int Receipt { get; private set; }
        public int PartKeplacementCost { get; private set; }
        public int Fine { get; private set; }
        public bool SuccessRepair { get; private set; }
        public List<Detail> Warehouse { get; private set; }

        public CarService()
        {
            Money = 3000;
            Receipt = 0;
            PartKeplacementCost = 150;
            Fine = 500;
            SuccessRepair = false;
            Warehouse = new List<Detail>();
            Warehouse.Add(new Detail("Колесо", 100));
            Warehouse.Add(new Detail("Армотизатор", 200));
            Warehouse.Add(new Detail("Свеча зажигания", 175));
        }

        public void CalculateCostRepair(Client client)
        {
            for (int i = 0; i < Warehouse.Count; i++)
            {
                for (int j = 0; j < client.Breaking.Count; j++)
                {
                    if (Warehouse[i].Name == client.Breaking[j].Name)
                    {
                        Receipt += Warehouse[i].Cost + PartKeplacementCost;
                    }
                }
            }
        }

        public void ShowReceipt()
        {
            Console.WriteLine($"Стоимость ремонта: {Receipt}");
        }

        public void RepairCar(Client client)
        {
            for (int i = 0; i < Warehouse.Count; i++)
            {
                for (int j = 0; j < client.Breaking.Count; j++)
                {
                    if (Warehouse[i].Name == client.Breaking[j].Name)
                    {
                        Warehouse.RemoveAt(i);
                        client.Breaking.RemoveAt(j);

                        i = -1;
                    }
                }
            }

            if (client.Breaking.Count == 0)
            {
                SuccessRepair = true;
            }
        }

        public void TakeMoney()
        {
            Money += Receipt;
        }

        public void PayFine()
        {
            Money -= Fine;
        }
    }

    class Client
    {
        public int Money { get; private set; }
        public bool SuccessPay { get; private set; }
        public List<Detail> Breaking { get; private set; }

        public static Random Rnd { get; private set; }

        public Client()
        {
            Money = 1000;
            SuccessPay = false;
            Breaking = new List<Detail>();
        }

        static Client()
        {
            Rnd = new Random();
        }

        public void CreateBreaking(CarService carService)
        {
            for (int i = 0; i < Rnd.Next(1, 3); i++)
            {
                Breaking.Add(carService.Warehouse[i]);
            }
        }

        public void ShowBreaking()
        {
            for (int i = 0; i < Breaking.Count; i++)
            {
                Console.WriteLine(Breaking[i].Name);
            }
        }

        public void PayRepair(CarService carService)
        {
            if (Money >= carService.Receipt)
            {
                Money -= carService.Receipt;
                SuccessPay = true;
            }
        }
    }

    class Detail
    {
        public string Name { get; private set; }
        public int Cost { get; private set; }

        public Detail(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService();
            Client client = new Client();

            client.CreateBreaking(carService);
            client.ShowBreaking();

            carService.CalculateCostRepair(client);
            carService.ShowReceipt();

            carService.RepairCar(client);

            if (carService.SuccessRepair == true)
            {
                Console.WriteLine("Ремонт прошел успешно");

                client.PayRepair(carService);

                if (client.SuccessPay == true)
                {
                    Console.WriteLine("Ремонт оплачен");

                    carService.TakeMoney();
                }
            }
            else
            {
                Console.WriteLine("Не удалось починить атомобиль");

                carService.PayFine();
            }

            Console.ReadKey();
        }
    }
}
