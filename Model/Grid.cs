using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    using Placement = IEnumerable<Square>;
    public class Grid
    {
        public Grid(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            squares = new Square[Rows, Cols];
            for (int r = 0; r < Rows; ++r)
            {
                for (int c = 0; c < Cols; ++c)
                    squares[r, c] = new Square(r, c);
            }
        }

  
        public IEnumerable<Placement> GetAvailablePlacments(int length)
        {
            if (length != 1)
                return GetAvailableHorizontalPlacements(length).Concat(GetAvailableVerticalPlacements(length));

            List<List<Square>> result = new List<List<Square>>();
            for (int r = 0; r < Rows; ++r)
            {
                for (int c = 0; c < Cols; ++c)
                    if (IsAvailable(r, c))
                        result.Add(new List<Square> { squares[r, c] });
            }
            return result;


        }
        public void EliminateSquares(Placement toEliminate)
        {
            foreach (var square in toEliminate)
                squares[square.Row, square.Col] = null;
        }

        


        public void MarkHitResult(Square square, HitResult hitResult)
        {
            squares[square.Row, square.Col].SetState(hitResult);
        }

        private IEnumerable<Placement> GetAvailableHorizontalPlacements(int length)
        {
            var result = new List<List<Square>>();
            for (int r = 0; r < Rows; ++r)
            {
                LimitedQueue<Square> passed = new LimitedQueue<Square>(length);
                for (int c = 0; c < Cols; ++c)
                {
                    if (IsAvailable(r, c))
                        passed.Enqueue(squares[r, c]);
                    else
                        passed.Clear();
                    if (passed.Count == length)
                    {
                        result.Add(passed.ToList());
                    }
                }
            }

            return result;
        }
        private IEnumerable<Placement> GetAvailableVerticalPlacements(int length)
        {
            var result = new List<List<Square>>();
            for (int c = 0; c < Cols; ++c)
            {
                int counter = 0;
                for (int r = 0; r < Rows; ++r)
                {
                    if (IsAvailable(r, c))
                    {
                        ++counter;
                    }
                    else
                    {
                        counter = 0;
                    }
                    if (counter >= length)
                    {
                        List<Square> seq = new List<Square>();
                        for (int first = r - length + 1; first <= r; ++first)
                        {
                            seq.Add(squares[first, c]);
                        }
                        result.Add(seq);
                    }
                }
            }
            return result;
        }

        private bool IsAvailable(int row,int col)
        {
            return squares[row, col] != null && squares[row,col].SquareState == SquareState.None;
        }

        public readonly int Rows;
        public readonly int Cols;

        private Square[,] squares;
    }
}