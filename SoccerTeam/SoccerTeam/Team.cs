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

        public string Print()
        {
            return $"{ name} - { points}";
        }

        public void UpdatePoints(Game game)
        {
            int gamePoints = game.GetTeamPoints(name);
                points = points + gamePoints;
        }
    }
}
