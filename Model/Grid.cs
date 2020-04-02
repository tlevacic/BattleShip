using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    using Placement=IEnumerable<Square>;

    public class Grid
    {
        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            squares = new Square[Rows, Columns];
            for (int r = 0; r < Rows; ++r)
            {
                for (int c = 0; c < Columns; ++c)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }
        public IEnumerable<Placement> GetAvailableVerticalPlacements(int length)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Placement> GetAvailablePlacements(int length)
        {
            if (length != 1)
            {
                List<List<Square>> result = new List<List<Square>>();
                for (int r = 0; r < Rows; ++r)
                {
                    for (int c = 0; c < Columns; ++c)
                    {
                        if (squares[r, c] != null)
                            result.Add(new List<Square> { squares[r, c] });   
  
                    }
                }
                return result;
            }
            return GetAvailableHorizontalPlacements(length).Concat(GetAvailableVerticalPlacements(length));
        }

        public void EliminateSquares(Placement toEliminate)
        {
            foreach(var square in toEliminate)
            {
                squares[square.Row, square.Col] = null;
            }
        }

        private IEnumerable<Placement> GetAvailableHorizontalPlacements(int length)
        {
            var result = new List<List<Square>>();
            for(int r = 0; r < Rows; ++r)
            {
                int cnt = 0;
                for(int c = 0; c < Columns; ++c)
                {
                    if (squares[r, c] != null)
                    {
                        ++cnt;
                    }
                    else
                        cnt = 0;
                    if (cnt >= length)
                    {
                        List<Square> seq = new List<Square>();
                        for(int first = c - length + 1; first <= c; ++first)
                        {
                            seq.Add(squares[r, first]);
                        }
                        result.Add(seq);
                    }
                }
            }

            return result;
        }

        public readonly int Rows;
        public readonly int Columns;

        private Square[,] squares;
    }
}