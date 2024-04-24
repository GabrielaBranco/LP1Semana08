using System;
using System.Collections;
namespace PlayerManager4
{
    public class Player : IComparable<Player>
    {
        public string Name { get; }
        public int Score { get; set;}

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other) //Sort list by score from higher to lower score
        {
            if (other == null) return 1;
            return other.Score - this.Score;
        }
    }
}