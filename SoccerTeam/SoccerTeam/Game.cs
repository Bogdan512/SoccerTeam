using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Game
    {
       string team1;
       string team2;
       int goalsTeam1;
       int goalsTeam2;

        public Game(string team1, string team2, int goalsTeam1, int goalsTeam2)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.goalsTeam1 = goalsTeam1;
            this.goalsTeam2 = goalsTeam2;
        }

        public string Print()
        {
            return $"{team1} - {team2}, {goalsTeam1} - {goalsTeam2}";
        }

        bool HasPlayed(string team)
        {
            if (team == team1) return true;
            if (team == team2) return true;
            return false;
        }

        bool IsADraw()
        {
            if (goalsTeam1 == goalsTeam2)
                return true;
            return false;
        }

        string Winner()
        {
            if (goalsTeam1 > goalsTeam2)
                return team1;
            return team2;
        }

        public int GetTeamPoints(string team)
        {
            if (HasPlayed(team) && IsADraw())
                return 1;
            if (Winner() == team)
                return 3;
            return 0;
        }
    }
}
