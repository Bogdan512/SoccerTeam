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
            string[] actual = ranking.Print();

            Console.Read();
        }
    }
}
