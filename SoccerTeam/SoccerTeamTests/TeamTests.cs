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
            var teams = new Team[]
            {
                new Team("CFR",  37),
                new Team("Astra",35),
                new Team("FC",33)
            };
           
            Ranking ranking = new Ranking(teams);

            string[] expected = { "CFR - 37", "Astra - 35", "FC - 33" };
            string[] actual = ranking.Print();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_If_Update_Updates_With_new_Values()
        {
            // ARRANGE
            var ranking = new Ranking(new Team[]
            {
                new Team("CFR",  37),
                new Team("Astra",35),
                new Team("FC",   33)
            });

            // ACT
            ranking.Update(new Game("Astra", "FC", 3, 1));

            // ASSERT
            string[] expected = { "Astra - 38", "CFR - 37", "FC - 34" };
            Assert.Equal(expected, ranking.Print());
        }
    }
}
