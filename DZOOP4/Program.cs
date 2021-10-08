using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP4
{
    class Fighter
    {
        private int _hp;
        private int _damage;

        public Fighter(int hp, int damage)
        {
            _hp = hp;
            _damage = damage;
        }

        public void ToDmage(Fighter fighter1, Fighter fighter2, Random random)
        {
            fighter1._damage = random.Next(5, 20 + 1);
            fighter2._damage = random.Next(5, 20 + 1);

            if (fighter1._hp > 0 && fighter2._hp > 0)
            {
                fighter1._hp -= fighter2._damage;
                fighter2._hp -= fighter1._damage;
            }
        }

        public void ShowFighters(Fighter fighter1, Fighter fighter2)
        {
            Console.WriteLine($"Боец 1 - HP {fighter1._hp} - Урон {fighter1._damage} ");
            Console.WriteLine($"Боец 2 - HP {fighter2._hp} - Урон {fighter2._damage} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Fighter fighter1 = new Fighter(100, random.Next(5, 20 + 1));
            Fighter fighter2 = new Fighter(100, random.Next(5, 20 + 1));
            int comands = 0;
            bool exit = false;


            while (exit == false)
            {
                Console.WriteLine("1.Нанести удар \n2.Прекратить бой");

                comands = int.Parse(Console.ReadLine());

                switch (comands)
                {
                    case 1:
                        fighter1.ToDmage(fighter1, fighter2, random);
                        fighter1.ShowFighters(fighter1, fighter2);

                        Console.ReadKey();
                        break;
                    case 2:
                        exit = true;
                        break;
                }

                Console.Clear();
            }
        }
    }
}
