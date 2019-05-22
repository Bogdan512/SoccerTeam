using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Game
    {
       public readonly string team1;
        public readonly string team2;
        public readonly int pointsTeam1;
        public readonly int pointsTeam2;

        public Game(string team1, string team2, int pointsTeam1, int pointsTeam2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.pointsTeam1 = pointsTeam1;
            this.pointsTeam2 = pointsTeam2;
        }

        public string Print()
        {
            return $"{ team1} - { pointsTeam1}, { team2} - { pointsTeam2}";
        }
    }
}
