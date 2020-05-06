using System;
using System.Collections.Generic;
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
            lastTarget = new Square(0, 0);
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



        private Square lastTarget;
        private Grid evidenceGrid;
        private List<int> shipsToShoot;
        public ShootingTactics ShootingTactics { get; private set; }
    }
}