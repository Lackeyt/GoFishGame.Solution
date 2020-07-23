using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game testGame = new Game();
      Assert.AreEqual(typeof(Game), testGame.GetType());
    }
  }
}