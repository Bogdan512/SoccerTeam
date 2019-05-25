using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SoccerTeam.Tests
{
    public class GameTests
    {
        [Fact]
        public void Sould_Return_The_Nr_Of_Points_A_Team_Gets_After_A_Game()
        {
            Game game = new Game("Sparta", "Craca", 1, 1);
            int actual = game.GetTeamPoints("Craca");
            int expected = 1;
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Should_Return_The_Name_And_Points_Of_Two_Teams_That_Played()
        {
            Game game = new Game("Ajax", "Fairy", 3, 1);
            string actual = game.Print();
            string expected = "Ajax - Fairy, 3 - 1";
        }
    }
}
