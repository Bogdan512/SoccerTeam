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

                    if (teams[i].name == game.team1)
                    {
                        teams[i] = new Team(game.team1, teams[i].points + game.pointsTeam1);
                    }
                    if (teams[i].name == game.team2)
                    {
                        teams[i] = new Team(game.team2, teams[i].points + game.pointsTeam2);
                    }              
            }
            BubbleSort(teams);
        }

        public static void BubbleSort(Team[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = 0; j < teams.Length - 1; j++)
                {
                    if (teams[j].points < teams[j + 1].points)
                    {
                        Team temp = teams[j];
                        teams[j] = teams[j + 1];
                        teams[j + 1] = temp;
                    }
                }
            }
        }
    }
}
