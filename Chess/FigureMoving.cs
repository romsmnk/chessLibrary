using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class FigureMoving
    {
        public Figure figure    { get; private set; }
        public Square from      { get; private set; }
        public Square to        { get; set; }
        public Figure promotion { get; private set; }

        public FigureMoving(FigureOnSquare fs, Square to, Figure promotion = Figure.none)
        {
            this.figure = fs.figure;
            this.from = fs.square;
            this.to = to;
            this.promotion = promotion;
        }
        public FigureMoving(string move) // Pe2e4   Pe7e8Q
        {                                // 01234   012345
            this.figure = (Figure)move[0];
            this.from = new Square(move.Substring(1,2));
            this.to = new Square(move.Substring(3,2));
            this.promotion = (move.Length == 6) ? (Figure)move[5] : Figure.none;
        }
    }
}
