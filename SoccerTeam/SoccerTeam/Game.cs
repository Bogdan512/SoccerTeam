using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Game
    {
       string team1;
       string team2;
       int pointsTeam1;
       int pointsTeam2;

        public Game(string team1, string team2, int pointsTeam1, int pointsTeam2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.pointsTeam1 = pointsTeam1;
            this.pointsTeam2 = pointsTeam2;
        }

        public string[] Print()
        {
            string[] result = new string[2];
            string teamOne = team1 + " - " + pointsTeam1.ToString();
            string teamTwo = team2 + " - " + pointsTeam2.ToString();
            result[0] = teamOne;
            result[1] = teamTwo;
            return result;
        }
    }
}
