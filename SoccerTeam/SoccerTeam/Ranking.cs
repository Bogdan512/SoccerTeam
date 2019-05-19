using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Ranking
    {
        string name;
        int points;

        public Ranking(string _name, int _points)
        {
            this.name = _name;
            this.points = _points;
        }
        public string[] Print(Ranking[] ranking )
        {
            string[] result = new string[ranking.Length];
            for (int i = 0; i < ranking.Length; i++)
            {
                Team team = new Team(ranking[i].name,ranking[i].points);
                result[i] = team.Print();
            }
            return result;
        }
    }
}
