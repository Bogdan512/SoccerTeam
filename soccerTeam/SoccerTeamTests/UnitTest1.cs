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
            Team[] aTeam = new Team[]
            {
                new Team( "CFR", 35 ),
                new Team( "UCLUJ",33 ),
                new Team( "Steaua",28 ),
            };
            string[] expected = { ("CFR- 35"), ("UCLUJ- 33"), ("Steaua- 28") };
            string[] actualTeam = team.Print(aTeam);
            Assert.Equal(expected, actualTeam);
        }
    }
}
