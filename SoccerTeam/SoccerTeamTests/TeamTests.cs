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
        public void Check_If_RankingPrint_Returns_A_Team()
        {
            Team team = new Team("Barsa", 14);
            Ranking ranking = new Ranking();
            string actual = ranking.Print(team);
            Assert.Equal("Barsa - 14", actual);
        }
    }
}
