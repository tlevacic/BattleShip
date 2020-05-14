using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestGunner
    {
        [TestMethod]
        public void InitiallyShootingTacticsIsRandomAsLongAsFirstSquareIsHit()
        {
            int[] shipLenghts = new int[] { 1, 2, 3 };
            Gunner g = new Gunner(6, 6, shipLenghts);
            Assert.AreEqual(ShootingTactics.Random, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Missed);
            Assert.AreEqual(ShootingTactics.Random, g.ShootingTactics);

        }



        [TestMethod]
        public void ShootingTacticsChangesFromRandomToSurroundiungAfterFirstSquareIsHit()
        {
            int[] shipLenghts = new int[] { 1, 2, 3 };
            Gunner g = new Gunner(6, 6, shipLenghts);
            Assert.AreEqual(ShootingTactics.Random, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Hit);
            Assert.AreEqual(ShootingTactics.Surrounding, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Missed);
            Assert.AreEqual(ShootingTactics.Surrounding, g.ShootingTactics);
        }

        [TestMethod]
        public void ShootingTacticsChangesFromSurroundingToLinegAfterSecondSquareIsHit()
        {
            int[] shipLengths = new int[] { 1, 2, 3 };
            Gunner g = new Gunner(6, 6, shipLengths);
            Assert.AreEqual(ShootingTactics.Random, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Hit);
            Assert.AreEqual(ShootingTactics.Surrounding, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Hit);
            Assert.AreEqual(ShootingTactics.Inline, g.ShootingTactics);
        }

        [TestMethod]
        public void ShootingTacticsChangesFromInlineToRandomgAfterShipIsSunk()
        {
            int[] shipLenghts = new int[] { 1, 2, 3 };
            Gunner g = new Gunner(6, 6, shipLenghts);
            Assert.AreEqual(ShootingTactics.Random, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Hit);
            Assert.AreEqual(ShootingTactics.Surrounding, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Hit);
            Assert.AreEqual(ShootingTactics.Inline, g.ShootingTactics);

            g.NextTarget();
            g.ProcessHitResult(HitResult.Sunken);
            Assert.AreEqual(ShootingTactics.Random, g.ShootingTactics);
        }
    }
}
