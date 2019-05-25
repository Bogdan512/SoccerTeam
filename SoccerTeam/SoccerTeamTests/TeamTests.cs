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
        public void Should_Return_The_Name_Of_A_Team()
        {
            Team team = new Team("Valenii din Vale", 3);
            string actual = team.GetTeamName();
            Assert.Equal("Valenii din Vale", actual);
        }

        [Fact]
        public void Should_Return_The_Nr_Of_Points_A_Team_Has()
        {
            Team team = new Team("Valenii din Vale", 3);
            int actual = team.GetTeamPoints();
            Assert.Equal(3, actual);
        }
    }
}
