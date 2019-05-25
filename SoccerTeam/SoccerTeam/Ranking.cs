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

        public void Update(Game game)
        {
            for (int i = 0; i < teams.Length; i++)
            {
               teams[i].UpdatePoints(game);
            }
            Sort();
        }

        void Sort()
        {
            for (int j = 0; j < teams.Length - 1; j++)
            {
                string team = teams[j].Print();
                string teamPlus1 = teams[j + 1].Print();
                if (Convert.ToInt32(team.Length - 1) < Convert.ToInt32(teamPlus1.Length - 1))
                {
                    Team temp = teams[j];
                    teams[j] = teams[j + 1];
                    teams[j + 1] = temp;
                }
            }
        }
    }
}
