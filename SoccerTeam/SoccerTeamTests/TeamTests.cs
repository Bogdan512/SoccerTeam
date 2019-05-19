using System;
using Xunit;

namespace SoccerTeam.Tests
{
    public class TeamTests
    {
        [Fact]
        public void Check_If_Print_Returns_A_Team()
        {
            Team team = new Team("A", 3);
            string actualTeam = team.Print();
            Assert.Equal("A - 3", actualTeam);
        }
    }

    public class RankingTests
    {
        [Fact]
        public void Check_If_RankingPrint_Returns_All_Teams_In_The_Input_Order()
        {
            Ranking rank = new Ranking("Barsa", 38);
            Ranking[] ranking = new Ranking[]
            {
                new Ranking("CFR", 37),
                new Ranking("Astra",35),
                new Ranking("FC",33)
            };
            string[] expected = { "CFR - 37", "Astra - 35", "FC - 33" };
            string[] actual = rank.Print(ranking);
            Assert.Equal(expected, actual);
        }
    }
}
