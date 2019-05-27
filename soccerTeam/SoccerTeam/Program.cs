using System;

namespace SoccerTeam
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //ARRANGE
            var ranking = new Ranking(new Team[]
            {
                new Team("Bistrita",32),
                new Team("Astra",35),
                new Team("UCluj",  33),
                new Team("Ajax",   31),
                new Team("CFR",  37),
                new Team("FC",   33),
            });

            //ACT
            ranking.Update(new Game("Ajax", "Astra", 1, 1));
            string[] actual = ranking.Print();
            foreach(string s in actual)
            {
                Console.WriteLine(s);
            }

            //ASSERT
            string[] expected = { "CFR - 37", "Astra - 35", "FC - 33", "UCluj - 33", "Ajax - 32", "Bistrita - 32" };
            Console.Read();
        }
    }
}
