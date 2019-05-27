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

        public int CompareTo(Team other)
        {
            if (other.points < points)
            {
                return -1;
            }
            if (other.points > points)
            {
                return 1;
            }
            else return 0;
        }
    }
}
