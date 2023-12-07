using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_of_Life;

namespace UnitTestGameOfLife
{
    [TestClass]
    public class GameEngineTests
    {
        [TestMethod]
        public void TestNextGeneration()
        {
            GameEngine gameEngine = new GameEngine(3, 3, 1, 1);
            bool[,] initialGeneration = gameEngine.GetCurrentGeneration();

            gameEngine.NextGeneration();
            bool[,] nextGeneration = gameEngine.GetCurrentGeneration();

            Assert.AreNotEqual(initialGeneration, nextGeneration);
        }

        [TestMethod]
        public void TestAddCell()
        {
            GameEngine gameEngine = new GameEngine(3, 3, 1, 1);
            bool[,] initialGeneration = gameEngine.GetCurrentGeneration();

            gameEngine.AddCell(1, 1);
            bool[,] updatedGeneration = gameEngine.GetCurrentGeneration();

            Assert.AreNotEqual(initialGeneration, updatedGeneration);
            Assert.IsTrue(updatedGeneration[1, 1]);
        }

        [TestMethod]
        public void TestRemoveCell()
        {
            GameEngine gameEngine = new GameEngine(3, 3, 1, 1);
            gameEngine.AddCell(1, 1);
            bool[,] initialGeneration = gameEngine.GetCurrentGeneration();

            gameEngine.RemoveCell(1, 1);
            bool[,] updatedGeneration = gameEngine.GetCurrentGeneration();

            Assert.AreNotEqual(initialGeneration, updatedGeneration);
            Assert.IsFalse(updatedGeneration[1, 1]);
        }

        [TestMethod]
        public void TestClearTable()
        {
            GameEngine gameEngine = new GameEngine(3, 3, 1, 1);
            gameEngine.AddCell(1, 1);
            bool[,] initialGeneration = gameEngine.GetCurrentGeneration();

            gameEngine.ClearTable();
            bool[,] clearedGeneration = gameEngine.GetCurrentGeneration();

            Assert.AreNotEqual(initialGeneration, clearedGeneration);
            CollectionAssert.AreEqual(new bool[3, 3], clearedGeneration);
        }
        [TestMethod]
        public void TestGetCurrentGenerationAfterNextGeneration()
        {
            GameEngine gameEngine = new GameEngine(3, 3, 1, 1);
            bool[,] initialGeneration = gameEngine.GetCurrentGeneration();

            gameEngine.NextGeneration();
            bool[,] nextGeneration = gameEngine.GetCurrentGeneration();

            Assert.AreNotEqual(initialGeneration, nextGeneration);
            CollectionAssert.AreEqual(nextGeneration, gameEngine.GetCurrentGeneration());
        }
    }
}
