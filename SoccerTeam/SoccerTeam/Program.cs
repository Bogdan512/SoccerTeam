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

            // ACT
            string[] actual = ranking.Update(new Game("Astra", "FC", 3, 1));
            string[] expected = { "Astra - 38", "CFR - 37", "FC - 33" };

            foreach (string s in actual)
            {
                Console.WriteLine(s);
            }
            

            Console.Read();
        }
    }
}
