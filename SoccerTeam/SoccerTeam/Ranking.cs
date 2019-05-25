using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Ranking
    {
        private Team[] teams;
        private Game game;
        
        public Ranking(Team[] teams)
        {
            this.teams = teams;
        }

        public Ranking(Game games)
        {
            this.game = games;
        }
        public string[] Print()
        {
            string[] result = new string[teams.Length]; ;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = teams[i].Print();
            }
            return result;
        }

        public string[] Update(Game game)
        {
            string[] result = new string[teams.Length];
            for (int i = 0; i < teams.Length; i++)
            {
                string teamName = teams[i].GetTeamName();
                int teamPoints = teams[i].GetTeamPoints();
                string[] gameTeamsNames= game.GetTeamsNames();
                int gameTeamPoints = game.GetTeamPoints(teamName);
                int sumPoints = 0;
                if (teamName == gameTeamsNames[0])
                {
                    sumPoints = teamPoints + gameTeamPoints;
                    result[i] = teamName + " - " + sumPoints;
                    continue;
                }
                if (teamName == gameTeamsNames[1])
                {
                    sumPoints = teamPoints + gameTeamPoints;
                    result[i] = teamName + " - " + sumPoints;
                    continue;
                }
                else result[i] = teams[i].Print();
            }
            Sort(result);
            return result;
        }

            public void Sort(string[] str)
        {
            for (int j = 0; j < str.Length - 1; j++)
            {
                if (str[j][Convert.ToInt32(str.Length-1)] < str[j + 1][Convert.ToInt32(str.Length - 1)])
                {
                    string temp = str[j];
                    str[j] = str[j + 1];
                    str[j + 1] = temp;
                }
            }
        }
    }
}
