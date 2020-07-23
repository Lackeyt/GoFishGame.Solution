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
      List<string[]> result = new List<string[]> {};
      string[] test = {"test", "test"};
      string[] test2 = {"test2", "test2"};
      result.Add(test);
      result.Add(test2);
      Assert.ToEqual(2, result.Count);
    }
  }
}