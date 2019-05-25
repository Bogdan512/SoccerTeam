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

        public string Print()
        {
            return $"{team1} - {team2}, {pointsTeam1} - {pointsTeam2}";
        }

        public int GetTeamPoints(string team)
        {
            int result = 0;

            if (team == team1)
            {
                result = pointsTeam1;
            }
            if (team == team2)
            {
                result = pointsTeam2;
            }
            return result;
        }

        public string GetScore()
        {
            return $"{team1} - {team2}, {pointsTeam1} - {pointsTeam2}";
        }
    }
}
