using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Square
    {
        public readonly int Row, Col;

        public Square(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
