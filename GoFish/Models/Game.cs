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
      CurrentPlayerTurn = 0;
    }

    private void PopulateDeck()
    {
      string[] values = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
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
        int deckLocation = something.Next(_deck.Count);
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

    public bool CheckForMatch(string guess)
    {
      bool isMatch = false;
      int notCurrentPlayer = Math.Abs(CurrentPlayerTurn - 1);
      for (int i=0; i < _players[notCurrentPlayer].PlayerHand.Count; i++)
      {
        string[] card = _players[notCurrentPlayer].PlayerHand[i];
        if(guess == card[0])
        {
          isMatch = true;
          TakeMatchedCard(guess, card);
          break;
        }
      }
      if (isMatch == false) {
        DrawCard(CurrentPlayerTurn, 1);
        CurrentPlayerTurn = notCurrentPlayer;
      }
      return isMatch;
    }

    public void TakeMatchedCard(string guess, string[] card)
    {
      int notCurrentPlayer = Math.Abs(CurrentPlayerTurn - 1);
      _players[CurrentPlayerTurn].PlayerHand.Add(card);
      _players[notCurrentPlayer].PlayerHand.Remove(card);
    }

    public bool IsGameOver()
    {
      foreach (Player player in _players)
      {
        if(player.PlayerHand.Count ==0)
        {
          return true;
        }
      }
      return false;
    }

    public void RemoveDuplicatesAddScore()
    {
      bool DuplicatesFlag = false;
      do 
      {
        DuplicatesFlag = false;
        for (int i = 0; i < _players[CurrentPlayerTurn].PlayerHand.Count -1; i++)
        {
          string[] card1 = _players[CurrentPlayerTurn].PlayerHand[i];
          for(int j = i+1; j <_players[CurrentPlayerTurn].PlayerHand.Count; j++)
          {
            string[] card2 = _players[CurrentPlayerTurn].PlayerHand[j];
            if ( card1[0] == card2[0])
            {
              _players[CurrentPlayerTurn].PlayerHand.Remove(card1);
              _players[CurrentPlayerTurn].PlayerHand.Remove(card2);
              _players[CurrentPlayerTurn].Score += 1;
              DuplicatesFlag = true;
            }
          }
        }
      } while (DuplicatesFlag == true);
    }


  }
}


// create game -> create players -> player 1 turn (UI choose card) -> CheckForMatch() -> player 2 turn <game end check> <score iteration / remove duplicates from hand>