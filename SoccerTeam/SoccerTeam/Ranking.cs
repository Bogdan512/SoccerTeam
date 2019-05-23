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
            string[] gamePrint = game.Print();
            string[] result = new string[teams.Length];
            for (int i = 0; i < teams.Length; i++)
            {
                string[] teamsSplit = teams[i].Print().Split('-');
                string[] gamePrintSplit1 = gamePrint[0].Split('-');
                string[] gamePrintSplit2 = gamePrint[1].Split('-');
                if (teamsSplit[0] == gamePrintSplit1[0])
                {
                    int teamsSplitPoints = Convert.ToInt32(teamsSplit[1]);
                    int gamePrintSplitPoints = Convert.ToInt32(gamePrintSplit1[1]);
                    int sumPoints = teamsSplitPoints + gamePrintSplitPoints;
                    result[i] = teamsSplit[0] + "- " + sumPoints.ToString();
                    continue;
                }
                if (teamsSplit[0] == gamePrintSplit2[0])
                {
                    int teamsSplitPoints = Convert.ToInt32(teamsSplit[1]);
                    int gamePrintSplitPoints = Convert.ToInt32(gamePrintSplit2[1]);
                    int sumPoints = teamsSplitPoints + gamePrintSplitPoints;
                    result[i] = teamsSplit[0] + "- " + sumPoints.ToString();
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
