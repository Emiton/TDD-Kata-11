using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class SorterTests
    {

        [Test]
        public void noneDrawn()
        {
            var Drawings = new Sorter();
            List<int> input = new List<int>();
            List<int> output = Drawings.Balls();
            Assert.AreEqual(input.Count, output.Count);
            Assert.AreEqual(output, input);
        }

        [Test]
        public void oneDrawn()
        {
            var Drawings = new Sorter();
            List<int> input = new List<int> { 5 };
            Drawings.Draw(5);
            List<int> output = Drawings.Balls();
            Assert.AreEqual(input.Count, output.Count);
            Assert.AreEqual(output, input);
        }

        [Test]
        public void twoDrawn()
        {
            var Drawings = new Sorter();
            List<int> input = new List<int> { 5, 6 };
            Drawings.Draw(5);
            Drawings.Draw(6);
            List<int> output = Drawings.Balls();
            Assert.AreEqual(input.Count, output.Count);
            Assert.AreEqual(output, input);
        }

        [Test]
        public void unsortedThreeDrawn()
        {
            var Drawings = new Sorter();
            List<int> input = new List<int> { 3, 4, 5 };
            Drawings.Draw(4);
            Drawings.Draw(5);
            Drawings.Draw(3);
            List<int> output = Drawings.Balls();
            Assert.AreEqual(input.Count, output.Count);
            output = Drawings.Sorted();
            Assert.AreEqual(output, input);
        }


        [Test]
        public void unsortedTenDrawn()
        {
            var Drawings = new Sorter();
            List<int> input = new List<int> { 3, 4, 5, 11, 15, 17, 19, 20, 33, 38 };
            Drawings.Draw(4);
            Drawings.Draw(5);
            Drawings.Draw(3);
            Drawings.Draw(11);
            Drawings.Draw(15);
            Drawings.Draw(38);
            Drawings.Draw(33);
            Drawings.Draw(20);
            Drawings.Draw(19);
            Drawings.Draw(17);
            List<int> output = Drawings.Balls();
            Assert.AreEqual(input.Count, output.Count);
            output = Drawings.Sorted();
            Assert.AreEqual(output, input);
        }
    }

    public class Sorter
    {
        List<int> Draws = new List<int>();

        public List<int> Balls()
        {
            return Draws;
        }

        public void Draw(int oneBall)
        {
            Draws.Add(oneBall);
        }

        public List<int> Sorted()
        {
            Draws.Sort();
            return Draws;
        }
    }

}