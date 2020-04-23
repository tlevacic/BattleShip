using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestFleet
    {
        [TestMethod]
        public void AddShipCreatesNewShipInTheFleet()
        {
            Fleet fleet = new Fleet();
            fleet.AddShip(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1, 6) });
            Assert.AreEqual(1, fleet.Ships.Count());
            Assert.IsTrue(fleet.Ships.First().Squares.Contains(new Square(1, 4)));
            Assert.IsTrue(fleet.Ships.First().Squares.Contains(new Square(1, 5)));
            Assert.IsTrue(fleet.Ships.First().Squares.Contains(new Square(1, 6)));


            fleet.AddShip(new List<Square> { new Square(4, 5), new Square(5, 5), new Square(6, 5) });
            Assert.AreEqual(2, fleet.Ships.Count());
        }

        [TestMethod]
        public void HitShipReturnsResultOfShooting()
        {

            Fleet fleet = new Fleet();
            fleet.AddShip(new List<Square> { new Square(1, 4), new Square(1, 5), new Square(1,6) });
            fleet.AddShip(new List<Square> { new Square(4, 5), new Square(5, 5) });
            
            var hit= fleet.Hit(new Square(1,4));
            Assert.AreEqual(HitResult.Hit, hit);

            hit = fleet.Hit(new Square(1, 5));
            Assert.AreEqual(HitResult.Hit, hit);

            hit = fleet.Hit(new Square(1, 6));
            Assert.AreEqual(HitResult.Sunken, hit);

            hit = fleet.Hit(new Square(1, 9));
            Assert.AreEqual(HitResult.Missed, hit);

            hit = fleet.Hit(new Square(4,5));
            Assert.AreEqual(HitResult.Hit, hit);

            hit = fleet.Hit(new Square(5, 5));
            Assert.AreEqual(HitResult.Sunken, hit);
        }
    }
}