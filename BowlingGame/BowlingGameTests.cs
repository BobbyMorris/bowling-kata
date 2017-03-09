using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    [TestFixture]
    public class BowlingGameTests
    {
        [Test]
        public void TestGutterGame()
        {
            Game g = new Game();
            for (int i=0; i<20; i++) g.Roll(0);
            Assert.AreEqual(0, g.Score());
        }
    }
}
