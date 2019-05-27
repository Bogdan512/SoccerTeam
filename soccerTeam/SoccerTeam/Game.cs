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

        string HasPlayed(string team)
        {
            if (team == team1) return team1;
            if (team == team2) return team2;
            return team;
        }

        bool IsDraw()
        {
            return true;
        }

        bool IsWinner()
        {
            return true;
        }

        public int GetTeamPoints(string team)
        {
            if(HasPlayed(team) != team && IsDraw())
            {
                return 1;
            }

            if (HasPlayed(team) == team1)
            {
                if (IsWinner())
                    return 3;
                if (!IsWinner())
                    return 0;
            }
            if (HasPlayed(team) == team2)
            {
                if (IsWinner())
                    return 3;
                if (!IsWinner())
                    return 0;
            }
            return -45;
        }
    }
}
