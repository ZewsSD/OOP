using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP9
{
    class Fish
    {
        private int _age;
        private bool _life;

        private static Random _rnd;

        static Fish()
        {
            _rnd = new Random();
        }

        public Fish()
        {
            _age = 0;
            _life = true;
        }

        public void Aging()
        {
            if (_life == true)
            {
                _age += _rnd.Next(1, 3 + 1);

                if (_age >= 10)
                {
                    _life = false;
                }
            }
        }

        public void ShowInfo(int index)
        {
            Console.WriteLine($"Возраст рыбки {index}: {_age}");

            if (_life == false)
            {
                Console.WriteLine($"Рыбка {index} отбросила коньки");
            }
        }
    }

    class Aquarium
    {
        private int _maxCountFish;
        private int _minCountFish;
        private List<Fish> _fishes;

        public Aquarium(List<Fish> fishes)
        {
            _fishes = fishes;
            _maxCountFish = 10;
            _minCountFish = 0;
        }

        public void AddFish()
        {
            if (_fishes.Count <= _maxCountFish)
            {
                _fishes.Add(new Fish());
            }
            else
            {
                Console.WriteLine("Нельзя добавить рыбку");
            }
        }

        public void GetHoldOfFish(int index)
        {
            if (_fishes.Count > _minCountFish)
            {
                _fishes.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Нельзя достать рыбку");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Fish> fishes = new List<Fish>();
            Aquarium aquarium = new Aquarium(fishes);

            int menu = 0;
            int indexFish = 0;
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("Дабавить рыбку - 1 \nДостать рыбку - 2 \nВыйти - 3");

                menu = int.Parse(Console.ReadLine());

                for (int i = 0; i < fishes.Count; i++)
                {
                    fishes[i].ShowInfo(i + 1);
                }

                for (int i = 0; i < fishes.Count; i++)
                {
                    fishes[i].Aging();
                }

                switch (menu)
                {
                    case 1:
                        aquarium.AddFish();
                        break;
                    case 2:
                        Console.WriteLine("Введите номер рыбки: ");
                        indexFish = int.Parse(Console.ReadLine()) - 1;

                        aquarium.GetHoldOfFish(indexFish);
                        break;
                    case 3:
                        exit = true;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
