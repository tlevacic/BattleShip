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

        }
        public Square NextTarget()
        {
            // TODO: implement correctly!
            lastTarget = SelectTarget();
            return lastTarget;
        }



        public void ProcessHitResult(HitResult hitResult)
        {
            evidenceGrid.MarkHitResult(lastTarget, hitResult);
            switch (hitResult)
            {
                case HitResult.Missed:
                    return;
                case HitResult.Sunken:
                    ShootingTactics = ShootingTactics.Random;
                    return;
                case HitResult.Hit:
                    switch (ShootingTactics)
                    {
                        case ShootingTactics.Random:
                            ShootingTactics = ShootingTactics.Surrounding;
                            return;
                        case ShootingTactics.Surrounding:
                            ShootingTactics = ShootingTactics.Inline;
                            return;
                        case ShootingTactics.Inline:
                            return;
                    }
                    break;
            }
            // modify shooting tactics
            // - if missed - no change
            // - if first hit - change to surrounding 
            // - if second hit - change to inline
            // - if sunken - change to random
        }

        private Square SelectTarget()
        {
            switch (ShootingTactics)
            {
                case ShootingTactics.Random:
                    return SelectRandomly();
                case ShootingTactics.Surrounding:
                    return SelectFromArround();
                case ShootingTactics.Inline:
                    return SelectInline();
                default:
                    Debug.Assert(false);
                    return null;
                        
                    }
        }

        private Square SelectRandomly()
        {
            var placements = evidenceGrid.GetAvailablePlacments(shipsToShoot[0]);
            var allCandidates = placements.SelectMany(seq => seq);
            int index = random.Next(0, allCandidates.Count());
            return allCandidates.ElementAt(index);
        }

        private Square SelectInline()
        {
            throw new NotImplementedException();
        }

        private Square SelectFromArround()
        {
            throw new NotImplementedException();
        }



        private Square lastTarget;
        private Grid evidenceGrid;
        private Random random = new Random();
        private List<int> shipsToShoot;
        public ShootingTactics ShootingTactics { get; private set; }
    }
}