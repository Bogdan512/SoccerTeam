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
            if (team == team1)
            {
                return pointsTeam1;
            }
            if (team == team2)
            {
                return pointsTeam2;
            }
            else return -45;
        }

        public string[] GetTeamsNames()
        {
            string[] result = new string[2];
            result[0] = team1;
            result[1] = team2;
            return result;
        }
    }
}
