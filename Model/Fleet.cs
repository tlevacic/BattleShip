using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Fleet
    {
        public void AddShip(IEnumerable<Square> squares)
        {
            ships.Add(new Ship(squares));
        }

        public IEnumerable<Ship> Ships
        {
            get { return ships; }
        }

        public HitResult Hit(Square square)
        {
            foreach(Ship ship in ships)
            {
                HitResult hit = ship.Hit(square);
                if (hit != HitResult.Missed)
                    return hit;
            }
            return HitResult.Missed;
        }

        private List<Ship> ships = new List<Ship>();
    }
}