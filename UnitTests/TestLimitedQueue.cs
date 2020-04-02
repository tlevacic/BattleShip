using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Battleship.Model.UnitTests
{
    [TestClass]
    public class TestLimitedQueue
    {
        [TestMethod]

        public void AddingItemsBehindLimitRemovesFirstIn()
        {
            LimitedQueue<int> q= new LimitedQueue<int>(3);
            Assert.AreEqual(0, q.Count);
            q.Enqueue(1);
            Assert.AreEqual(1, q.Count);
            q.Enqueue(2);
            Assert.AreEqual(2, q.Count);
            q.Enqueue(3);
            Assert.AreEqual(3, q.Count);
            q.Enqueue(4);
            Assert.AreEqual(3, q.Count);
            Assert.IsFalse(q.Contains(4));
        }
    }
}
