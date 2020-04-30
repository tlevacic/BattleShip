using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public enum SquareState
    {
        None,
        Missed,
        Hit,
        Sunken
    }
    public class Square : IEquatable<Square>
    {
        public Square(int row, int col)
        {
            Row = row;
            Col = col;
            Hit = false;
            SquareState=SquareState.None;
        }
        public void SetState(HitResult hitResult)
        {
            switch (hitResult)
            {
                case HitResult.Missed:
                    SquareState = SquareState.Missed;
                    break;
                case HitResult.Hit:
                    SquareState = SquareState.Hit;
                    break;
                case HitResult.Sunken:
                    SquareState = SquareState.Sunken;
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }
        }


        public bool Hit { get; set; }
        public readonly int Row;
        public readonly int Col;

        public SquareState SquareState { get; private set; }

        public bool Equals(Square other)
        {
            if (other == null)
                return false;
            return Row == other.Row && Col == other.Col;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Square)obj);
        }
        public override int GetHashCode()
        {
            return Row ^ Col;
        }

        public static bool operator==(Square lhs, Square rhs)
        {
            return Equals(lhs, rhs);
        }
        public static bool operator!=(Square lhs, Square rhs)
        {
            return !(lhs == rhs);
        }

    }
}