using System;

namespace SoccerTeam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("A", 4);
            Team[] aTeam = new Team[]
            {
                new Team( "CFR", 35 ),
                new Team( "UCLUJ",33 ),
                new Team( "Steaua",28 ),
            };
            string[] st = team.Print(aTeam);
            foreach(string s in st)
            {
                Console.WriteLine(s);
            }
            
            Console.Read();
        }
    }
}
