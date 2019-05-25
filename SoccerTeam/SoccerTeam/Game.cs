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
        Team team;

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

            if (team == team1 )
            {
                if (goalsTeam1 > goalsTeam2)
                    result = 3;
                if (goalsTeam1 < goalsTeam2)
                    result = 0;
                if(goalsTeam1 == goalsTeam2)
                    result = 1;
            }
            if (team == team2)
            {
                if (goalsTeam2 > goalsTeam1)
                    result = 3;
                if (goalsTeam2 < goalsTeam1)
                    result = 0;
                if (goalsTeam2 == goalsTeam1)
                    result = 1;
            }
            return result;
        }
    }
}
