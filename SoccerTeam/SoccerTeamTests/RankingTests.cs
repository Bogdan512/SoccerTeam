using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SoccerTeam.Tests
{
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
            //ARRANGE
           var ranking = new Ranking(new Team[]
           {
                new Team("CFR",  37),
                new Team("Astra",35),
                new Team("FC",   33)
           });

            //ACT
             ranking.Update(new Game("Astra", "FC", 3, 1));
            string[] actual = ranking.Print();

            //ASSERT
            string[] expected = { "Astra - 38", "CFR - 37", "FC - 33" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_If_Update_Updates_With_new_Values_When_They_Are_Already_Sorted()
        {
            //ARRANGE
            var ranking = new Ranking(new Team[]
            {
                new Team("CFR",  37),
                new Team("Astra",35),
                new Team("FC",   33),
                new Team("UCluj",  33),
                new Team("Bistrita",32),
                new Team("Ajax",   31),
            });

            //ACT
            ranking.Update(new Game("Ajax", "Astra", 1, 1));
            string[] actual = ranking.Print();

            //ASSERT
            string[] expected = {"CFR - 37", "Astra - 36", "FC - 33", "UCluj - 33", "Bistrita - 32", "Ajax - 32" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_If_Update_Updates_With_new_Values_When_They_Are_In_Revers_Order_From_Small_To_Big()
        {
            //ARRANGE
            var ranking = new Ranking(new Team[]
            {
                new Team("Ajax",   31),
                new Team("Bistrita",32),
                new Team("UCluj",  33),
                new Team("FC",   33),
                new Team("Astra",35),
                new Team("CFR",  37),
            });

            //ACT
            ranking.Update(new Game("Ajax", "Astra", 1, 1));
            string[] actual = ranking.Print();

            //ASSERT
            string[] expected = { "CFR - 37", "Astra - 36", "UCluj - 33", "FC - 33", "Ajax - 32", "Bistrita - 32",};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_If_Update_Updates_With_new_Values_When_They_Are_In_Random_Order()
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

            //ASSERT
            string[] expected = { "CFR - 37", "Astra - 36", "UCluj - 33", "FC - 33", "Bistrita - 32", "Ajax - 32" };
            Assert.Equal(expected, actual);
        }
    }
}
