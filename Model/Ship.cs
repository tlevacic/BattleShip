using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public enum HitResult
    {
        Missed,
        Hit,
        Sunken
    }
    public class Ship
    {
        public Ship(IEnumerable<Square> squares)
        {
            this.Squares = squares;
        }

        public HitResult Hit(Square square)
        {
            if (!Squares.Contains(square))
                return HitResult.Missed;
            Squares.First(s => s == square).Hit = true;
            if (Squares.Count(s => s.Hit) == Squares.Count())
                return HitResult.Sunken;
            return HitResult.Hit;
        }

        public readonly IEnumerable<Square> Squares;
    }
}