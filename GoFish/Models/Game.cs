using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    public int TurnCount { get; set; }
    private List<string[]> _deck = new List<string[]> {};
    private List<Player> _players = new List<Player> {};
    public int CurrentPlayerTurn { get; set; }

    public Game()
    {
      TurnCount = 1;
      this.PopulateDeck();
      CurrentPlayerTurn = 1;
    }

    private void PopulateDeck()
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

    public void AddPlayer(Player player)
    {
      _players.Add(player);
      // Logic for removing 5 cards from the deck and adding to players hand
    }

    public List<Player> GetPlayerList()
    {
      return _players;
    }

    public List<string[]> GetDeck()
    {
      return _deck;
    }
  }
}