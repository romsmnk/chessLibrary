using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    struct Square
    {
        public static Square none = new Square(-1, -1);

        public int x { get; private set; }
        public int y { get; private set; }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Square(string e2)
        {
            if (e2.Length == 2 &&
                e2[0] >= 'a'   && e2[0] <= 'h' &&
                e2[1] >= 1     && e2[1] <= 8)
            {
                x = e2[0] - 'a';
                y = e2[1] - '1';
            }
            else
                this = none;
        }

        public bool OnBoard() // проверка: клетка не вышла за доску
        {
            return x >= 0 && x < 8 &&
                   y >= 0 && y < 8;
        }
    }
}
