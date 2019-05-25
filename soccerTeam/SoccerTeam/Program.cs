using System;

namespace SoccerTeam
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var ranking = new Ranking(new Team[]
           {
                new Team("CFR",  37),
                new Team("Astra",35),
                new Team("FC",   33)
           });

            //ACT
            ranking.Update(new Game("Astra", "FC", 3, 1));
            string[] actual = ranking.Print();

            //ASSERT
            string[] expected = { "Astra - 38", "CFR - 37", "FC - 34" };
            Console.Read();
        }
    }
}
