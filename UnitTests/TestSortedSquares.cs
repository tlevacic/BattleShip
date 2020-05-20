using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestSortedSquares
    {
        [TestMethod]
        public void AfterNewSquareIsAddedHorizontallySquaresAreSortedByColumn()
        {
            SortedSquares s = new SortedSquares();
            s.Add(new Square(3, 4));
            s.Add(new Square(3, 3));
            Assert.AreEqual(new Square(3, 3), s.First());
            s.Add(new Square(3, 5));
            Assert.AreEqual(new Square(3, 5), s.Last());
        }

        [TestMethod]
        public void AfterNewSquareIsAddedVerticallySquaresAreSortedByRow()
        {
            SortedSquares s = new SortedSquares();
            s.Add(new Square(4, 4));
            s.Add(new Square(3, 4));
            Assert.AreEqual(new Square(3, 4), s.First());
            s.Add(new Square(5, 4));
            Assert.AreEqual(new Square(5, 4), s.Last());
        }

    }
}
