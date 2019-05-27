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
            int i;
            int j;

            for (i = 0; i < teams.Length; i++)
            {
                for (j = i; j < teams.Length; j++)
                {
                    if (teams[i].CompareTo(teams[j]) == 1)
                    {
                        Team temp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = temp;
                    }
                }
                
            }
        }
    }
}
