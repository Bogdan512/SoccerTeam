using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Team
    {
        string name;
        int points;

        public Team()
        {

        }

        public Team(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public void Print(Team[] teamsRanking)
        {
        for (int i = 0; i < teamsRanking.Length; i++)
            Console.WriteLine(teamsRanking[i].name + "- " + teamsRanking[i].points);
        }

        public Team[] ReadTeams()
        {
            int numberOfTeams = Convert.ToInt32(Console.ReadLine());
            Team[] result = new Team[numberOfTeams];
            for (int i = 0; i < result.Length; i++)
            {
                string[] teamData = Console.ReadLine().Split('-');
                int points = Convert.ToInt32(teamData[1]) + Convert.ToInt32(teamData[2]);
                result[i] = new Team(teamData[0], points);
            }
            return result;
        }
    }
}
