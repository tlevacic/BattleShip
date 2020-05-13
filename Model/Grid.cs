using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    using Placement = IEnumerable<Square>;

    public enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }

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

        public IEnumerable<Square> GetSquaresNextTo(Square square,Direction direction)
        {
            List<Square> result = new List<Square>();
            int row = square.Row;
            int column = square.Col;
            int deltaRow = 0;
            int deltaCol = 0;
            int maxCount = 0;
            switch (direction)
            {
                case Direction.Right:
                    ++column;
                    deltaCol = +1;
                    maxCount = Cols - column;
                    break;

                case Direction.Down:
                    ++row;
                    deltaRow = +1;
                    maxCount = Rows - row;
                    break;

                case Direction.Left:
                    maxCount = column;
                    --column;
                    deltaCol = -1;
                    break;

                case Direction.Up:
                    maxCount = row;
                    --row;
                    deltaRow = -1;
                    break;

                default:
                    Debug.Assert(false);
                    break;

            }

            for(int i = 0; i < maxCount && IsAvailable(row,column) ; ++i)
            {
                result.Add(squares[row, column]);
                row += deltaRow;
                column += deltaCol;
            }
            return result;
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

        public IEnumerable<IEnumerable<Square>> GetSquaresInline(IEnumerable<Square> squaresHit)
        {
            List<Placement> result = new List<Placement>();
            //Horizontal
            if(squaresHit.First().Row == squaresHit.Last().Row)
            {
                var l= GetSquaresNextTo(squaresHit.First(), Direction.Left);
                if (l.Count() > 0)
                    result.Add(l);

                l = GetSquaresNextTo(squaresHit.Last(), Direction.Right);
                if (l.Count() > 0)
                    result.Add(l);
            }
            //Vertical
            else if (squaresHit.First().Col == squaresHit.Last().Col)
            {
                var l = GetSquaresNextTo(squaresHit.First(), Direction.Up);
                if (l.Count() > 0)
                    result.Add(l);

                l = GetSquaresNextTo(squaresHit.Last(), Direction.Down);
                if (l.Count() > 0)
                    result.Add(l);
            }
            else
            {
                Debug.Assert(false);
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