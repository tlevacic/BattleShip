using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class SquareTerminator : ISquareTerminator
    {
        public SquareTerminator(int rows,int columns)
        {
            this.columns = columns;
            this.rows = rows;
        }
        public IEnumerable<Square> ToEliminate(IEnumerable<Square> shipSquares)
        {
            int left = shipSquares.First().Col;
            if (left > 0)
                --left;
            int top = shipSquares.First().Row;
            if (top > 0)
                --top;
            int right = shipSquares.Last().Col + 1;
            if (right < columns)
                ++right;
            int bottom = shipSquares.Last().Row + 1;
            if (bottom < rows)
                ++bottom;
            List<Square> toEliminate = new List<Square>();
            for (int r = top; r < bottom; ++r)
            {
                for (int c = left; c < right; c++)
                {
                    toEliminate.Add(new Square(r, c));
                }
            }
            return toEliminate;

        }
        
        private readonly int rows;
        private readonly int columns;
             
    }
}