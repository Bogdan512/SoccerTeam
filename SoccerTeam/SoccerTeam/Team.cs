using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Team
    {
        string name;
        int points;

        public Team(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static string[] Print(Team[] teamsRanking)
        {
            string[] result = new string[teamsRanking.Length];
            for (int i = 0; i < teamsRanking.Length; i++)
                result[i] = (teamsRanking[i].name + "- " + teamsRanking[i].points);
            return result;
        }
    }
}
