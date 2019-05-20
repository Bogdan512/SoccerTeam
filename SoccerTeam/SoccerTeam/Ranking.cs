using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Ranking
    {
        private Team[] teams ;
        public Ranking(Team[] _teams)
        {
            this.teams = _teams;
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
    }
}
