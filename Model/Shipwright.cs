using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Shipwright
    {
        public Shipwright(int rows, int cols, ISquareTerminator terminator)
        {
            this.terminator = terminator;
            this.rows = rows;
            this.cols = cols;
        }

        public Shipwright(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            terminator = new SquareTerminator(rows, cols);
        }

        public Shipwright()
        {
            rows = RulesSingelton.Instance.Rows;
            cols = RulesSingelton.Instance.Columns;
        }
        public Fleet CreateFleet(IEnumerable<int> shipLengths)
        {
            for (int i = 0; i < 3; i++)
            {
                Fleet fleet = PlaceShips(shipLengths);
                if (fleet != null)
                    return fleet;
            }
            throw new ArgumentOutOfRangeException();
        }

        private Fleet PlaceShips(IEnumerable<int> shipLengths)
        {
            List<int> lengths = new List<int>(shipLengths.OrderByDescending(x => x));

            Grid grid = new Grid(rows, cols);
            Fleet fleet = new Fleet();
            while (lengths.Count > 0)
            {
                var placements = grid.GetAvailablePlacments(lengths[0]);
                if (placements.Count() == 0)
                    return null;
                lengths.RemoveAt(0);
                int index = random.Next(0, placements.Count());
                fleet.AddShip(placements.ElementAt(index));
                var toEliminate = terminator.ToEliminate(placements.ElementAt(index));
                grid.EliminateSquares(toEliminate);

                if (lengths.Count() == 0)
                    return fleet;
            }
            return fleet;
        }
        private Random random = new Random();
        private readonly int rows;
        private readonly int cols;
        private readonly ISquareTerminator terminator;
    }
}