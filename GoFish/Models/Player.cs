using System.Collections.Generic;

namespace GoFish.Models
{
  public class Player
  {
    public List<string[]> PlayerHand = new List<string[]> {};
    public int Score { get; set; }

    public Player()
    {
      Score = 0;
    }
  }
}