﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void SquareConstructorCreateSquareWithGivenPosition()
        {
            Square s = new Square(1, 8);
            Assert.AreEqual(1, s.Row);
            Assert.AreEqual(8, s.Col);
        }

        [TestMethod]
        public void WhenShipIsSunkenAllSquaresAreMarkedSunken()
        {
            throw new NotImplementedException();
        }

    }
}