using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerTeam
{
    public class Ranking
    {
        private Team[] teams ;
        public Ranking(Team[] teams)
        {
            this.teams = teams;
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

        public string[] Update()
        {
            string[] result = new string[teams.Length];
            for (int i = 0; i < result.Length; i++)
            {

                result[i] = teams[i].Print();
            }
            return result;
        }

        //public string[] Update()
        //{
        //    string[] result = new string[teams.Length];
        //    string[] beforeGame = new string[this.teams.Length];
        //    string[] afterGame = new string[teams.Length];
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        beforeGame[i] = this.teams[i].Print();
        //        afterGame[i] = teams[i].Print();
        //        result[i] = teams[i].Print();
        //    }
        //    for (int j = 0; j < result.Length; j++)
        //    {
        //        for (int k = 0; k < result.Length; k++)
        //        {
        //            if (beforeGame[j][beforeGame.Length - 1] != afterGame[k][afterGame.Length - 1])
        //            {
        //                result[j] = afterGame[k];
        //            }
        //        }
        //    }


        //    return result;
        //}
    }
}
