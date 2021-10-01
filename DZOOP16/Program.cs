using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZOOP16
{
    class Warship
    {
        public string Name { get; private set; }
        public int HP { get; private set; }
        public int Damage { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public static int Count { get; private set; }

        static Warship()
        {
            Count = 0;
        }

        public Warship()
        {
            Count++;
        }

        public void PrintFields()
        {
            Console.WriteLine($"{Count}) {Name} {HP} {Damage} {Width} {Height}");
        }

        public void InitFields(string name, int hp, int damage, int width, int height)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            Width = width;
            Height = height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warship warship1 = new Warship();
            warship1.InitFields("ship1", 100, 10, 50, 20);
            warship1.PrintFields();

            Warship warship2 = new Warship();
            warship2.InitFields("ship2", 100, 10, 50, 20);
            warship2.PrintFields();

            Warship warship3 = new Warship();
            warship3.InitFields("ship3", 100, 10, 50, 20);
            warship3.PrintFields();

            Console.ReadKey();
        }
    }
}
