using System.Collections.Generic;
using System;

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
      PopulateDeck();
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
      DrawCard(_players.Count-1, 5);
    }

    public void DrawCard(int playerIndex, int numOfCards)
    {
      for (int i = numOfCards; i > 0; i--)
      {
        Random something = new Random();
        int deckLocation = something.Next(_deck.Count) -1;
        string[] drawnCard = _deck[deckLocation];
        _players[playerIndex].PlayerHand.Add(drawnCard);
        _deck.RemoveAt(deckLocation);
      }
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