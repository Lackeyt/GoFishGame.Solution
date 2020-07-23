using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System;

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

    [TestMethod]
    public void GameConstructor_ContainsDeckOf52Cards_CardList()
    {
      Game testGame = new Game();
      Assert.AreEqual(52, testGame.GetDeck().Count);
    }

    [TestMethod]
    public void GamePlayerList_ContainsListOfPlayers_PlayerList()
    {
      Game testGame = new Game();
      Player player1 = new Player();
      Player player2 = new Player();
      testGame.AddPlayer(player1);
      testGame.AddPlayer(player2);
      List<Player> testList = new List<Player>{};
      testList.Add(player1);
      testList.Add(player2);

      CollectionAssert.AreEqual(testList, testGame.GetPlayerList());

    }

  }
}