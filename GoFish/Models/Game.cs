using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    public int TurnCount { get; set; }
    private List<string[]> _deck = new List<string[]> {};

    public Game()
    {
      TurnCount = 1;
    }

    public void PopulateDeck()
    {
      string[] values = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
      string[] suites = {"Spades", "Clubs", "Diamonds", "Hearts"};
      string[] temp = {"", ""};

      foreach (string value in values)
      {
        foreach (string suite in suites)
        {
          temp[0] = value;
          temp[1] = suite;
          _deck.Add(temp);
        }
      }
    }

    public List<string[]> GetDeck()
    {
      return _deck;
    }
  }
}