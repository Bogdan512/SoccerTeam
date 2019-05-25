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

        [Fact]
        public void Should_Update_The_Points_Of_The_Team()
        {
            Team team = new Team("o echipa", 33);
            Game game = new Game("o echipa", "alta echipa", 1, 1);
            team.UpdatePoints(game);
            string actual = team.Print();
            Assert.Equal("o echipa - 34", actual);

        }
    }
}
