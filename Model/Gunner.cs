using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Vsite.Oom.Battleship.Model
{
    public enum ShootingTactics
    {
        Random,
        Surrounding,
        Inline
    }
    public class Gunner
    {
        public Gunner(int rows, int cols, IEnumerable<int> shipLengths)
        {

            evidenceGrid = new Grid(rows, cols);
            shipsToShoot=new List<int>(shipLengths.OrderByDescending(l => l));
            ShootingTactics = ShootingTactics.Random;
            squareTerminator = new SquareTerminator(rows, cols);
            shootingTacticsFactory= new ShootingTacticsFactory(evidenceGrid,squaresHit,shipsToShoot);
            targetSelect = shootingTacticsFactory.GetTactics(ShootingTactics.Random);

        }
        public Square NextTarget()
        {
            lastTarget = targetSelect.NextTarget();
            return lastTarget;
        }



        public void ProcessHitResult(HitResult hitResult)
        {
            evidenceGrid.MarkHitResult(lastTarget, hitResult);
            if (hitResult == HitResult.Missed)
                return;
            squaresHit.Add(lastTarget);
            if (hitResult == HitResult.Sunken)
            {
                var toEliminate = squareTerminator.ToEliminate(squaresHit);
                foreach (var sq in toEliminate)
                {
                    evidenceGrid.MarkHitResult(sq, HitResult.Missed);
                }
                foreach (var sq in squaresHit)
                {
                    evidenceGrid.MarkHitResult(sq, HitResult.Sunken);
                }
                int length = squaresHit.Length;
                shipsToShoot.Remove(length);
                squaresHit.Clear();
            }
            ChangeTactics(hitResult);
        }

        private void ChangeTactics(HitResult hitResult)
        {
            if (hitResult == HitResult.Sunken)
            {
                ShootingTactics = ShootingTactics.Random;
            }
            if (hitResult == HitResult.Hit)
            {
                switch (ShootingTactics)
                {
                    case ShootingTactics.Random:
                        ShootingTactics = ShootingTactics.Surrounding;
                        break;
                    case ShootingTactics.Surrounding:
                        ShootingTactics = ShootingTactics.Inline;
                        break;
                    case ShootingTactics.Inline:
                        return;
                }
            }
            targetSelect = shootingTacticsFactory.GetTactics(ShootingTactics);

        }


        private Square SelectRandomly()
        {
            var placements = evidenceGrid.GetAvailablePlacments(shipsToShoot[0]);
            // create simple array of sqaures from arrays of arrays
            var allCandidates = placements.SelectMany(seq => seq);
            // create groups with individual squares
            var groups = allCandidates.GroupBy(sq => sq);
            // find the number of squares in largest group
            var maxCount = groups.Max(g => g.Count());
            // filter only froups that have maxCount elements
            var largestGroups = groups.Where(g => g.Count() == maxCount);
            // fetch keys from each group (i.e. square that represents the group)
            var mostCommon = largestGroups.Select(g => g.Key);
            if (mostCommon.Count() == 1)
                return mostCommon.First();
            int index = random.Next(0, mostCommon.Count());
            return mostCommon.ElementAt(index);
        }

        private Square SelectFromArround()
        {
            List<IEnumerable<Square>> arround = new List<IEnumerable<Square>>();
            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                var l = evidenceGrid.GetSquaresNextTo(squaresHit.First(), direction);
                if (l.Count() > 0)
                    arround.Add(l);
            }
            if (arround.Count == 1)
                return arround[0].First();
            var ordered = arround.OrderByDescending(ls => ls.Count());
            int maxLen = ordered.First().Count();
            if (maxLen > shipsToShoot[0] - 1)
                maxLen = shipsToShoot[0] - 1;
            var longest = ordered.Where(ls => ls.Count() >= maxLen);
            int index = random.Next(0, longest.Count());
            return longest.ElementAt(index).First();
        }

        private Square SelectInline()
        {
            var l = evidenceGrid.GetSquaresInline(squaresHit);
            if (l.Count() == 1)
                return l.ElementAt(0).First();
            var ordered = l.OrderByDescending(ls => ls.Count());
            int maxLen = ordered.First().Count();
            if (maxLen > shipsToShoot[0] - squaresHit.Count())
                maxLen = shipsToShoot[0] - squaresHit.Count();
            var longest = ordered.Where(ls => ls.Count() >= maxLen);
            int index = random.Next(0, longest.Count());
            return longest.ElementAt(index).First();
        }

        private Square lastTarget;
        private ISquareTerminator squareTerminator;
        private Grid evidenceGrid;
        private SortedSquares squaresHit = new SortedSquares();
        private Random random = new Random();
        private List<int> shipsToShoot;
        private ITargetSelect targetSelect;
        public ShootingTactics ShootingTactics { get; private set; }
        private ShootingTacticsFactory shootingTacticsFactory;
    }
}