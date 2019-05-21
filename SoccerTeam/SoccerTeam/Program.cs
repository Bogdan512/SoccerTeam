using System;

namespace SoccerTeam
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var teams = new Team[]
               {
                new Team("CFR",  37),
                new Team("Astra",35),
                new Team("FC",33)
               };
            Ranking ranking = new Ranking(teams);
            var newValuesTeams = new Team[]
            {
                new Team("Astra",40),
                new Team("CFR",  38),
                new Team("FC",37)
            };

            Ranking ranking1 = new Ranking(newValuesTeams);
            string[] actual = ranking1.Update();
            foreach (string s in actual)
            {
                Console.WriteLine(s);
            }
            

            Console.Read();
        }
    }
}
