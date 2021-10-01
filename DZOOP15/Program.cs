using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZOOP15
{
    public class Symbol
    {
        private static Random _random;

        public string Signs { get; private set; }
        public char Sign { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public ConsoleColor Color { get; private set; }

        public Symbol(string signs, int x, int y, ConsoleColor color)
        {
            Signs = signs;
            X = x;
            Y = y;
            Color = color;
        }

        static Symbol()
        {
            _random = new Random();
        }

        public void Fall(int heidth)
        {
            Y++;

            if (Y > heidth)
                Y = 0;

            Sign = Signs[_random.Next(1, Signs.Length)];
        }
    }

    public class Matrix
    {
        private Symbol[] _symbols;
        private Random _random;
        private int _width;
        private int _heidth;
        private int _colorIndex;
        private ConsoleColor _color;

        public Matrix(int symbolsCount, int width, int heidth)
        {
            _random = new Random();
            _symbols = new Symbol[symbolsCount];
            _width = width;
            _heidth = heidth;
            _colorIndex = 0;
            _color = ConsoleColor.Green;

            for (int i = 0; i < symbolsCount; i++)
            {
                _colorIndex = _random.Next(0, 1 + 1);

                if (_colorIndex == 0)
                {
                    _color = ConsoleColor.Green;
                }
                else if (_colorIndex == 1)
                {
                    _color = ConsoleColor.Yellow;
                }

                _symbols[i] = new Symbol("qwertyuiop", _random.Next(1, width), _random.Next(1, heidth), _color);
            }
        }

        public void Print()
        {
            foreach (var item in _symbols)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.ForegroundColor = item.Color;
                Console.Write(item.Sign);
            }
        }

        public void Fall()
        {
            foreach (var item in _symbols)
            {
                item.Fall(_heidth);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 64);
            Matrix matrix = new Matrix(200, Console.WindowWidth, Console.WindowHeight);

            bool isSnowFall = true;
            ConsoleKey stopKey = ConsoleKey.E;

            while (isSnowFall)
            {
                Console.Clear();

                if (Console.KeyAvailable && Console.ReadKey().Key == stopKey)
                {
                    isSnowFall = false;
                }

                matrix.Print();
                matrix.Fall();

                Thread.Sleep(500);
            }
        }
    }
}
