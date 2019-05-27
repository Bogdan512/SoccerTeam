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

        public int GetTeamPoints(string team)
        {
            int result = 0;

            if(team == team1 || team == team2)
            {
                if (goalsTeam1 == goalsTeam2)
                return 1;
            }

            if (team == team1)
            {
                if (goalsTeam1 > goalsTeam2)
                    return 3;
                if (goalsTeam1 < goalsTeam2)
                    return 0;
            }
            if (team == team2)
            {
                if (goalsTeam2 > goalsTeam1)
                    return 3;
                if (goalsTeam2 < goalsTeam1)
                    return 0;
            }
            return result;
        }
    }
}
