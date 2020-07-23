using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class PlayerTests
  {

    [TestMethod]
    public void PlayerConstructor_PlayerObjectContainsListOfCardsInHand_2()
    {
      Player testPlayer = new Player();
      //List<string[]> result = new List<string[]> {};
      string[] test = {"test", "test"};
      string[] test2 = {"test2", "test2"};
      testPlayer.PlayerHand.Add(test);
      testPlayer.PlayerHand.Add(test2);
      Assert.AreEqual(2, testPlayer.PlayerHand.Count);
    }
  }
}