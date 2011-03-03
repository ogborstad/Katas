using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace YatzeeKataTests
{
    [TestFixture]
    public class Tests
    {
        private Yahtzee yahtzee;
        
        [SetUp]
        public void Setup()
        {
            yahtzee = new Yahtzee();
        }

        [TestCase(1, 2, 3, 4, 5, 15)]
        [TestCase(6, 2, 3, 4, 5, 20)]
        [TestCase(6, 6, 6, 6, 6, 30)]
        public void Chance_should_sum_up_all_dice(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Chance, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(1, 2, 3, 4, 5, 1)]
        [TestCase(1, 1, 1, 1, 1, 5)]
        public void Ones_should_sum_up_all_dice_with_one_eye(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Ones, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(2, 2, 2, 2, 2, 10)]
        [TestCase(1, 1, 1, 1, 1, 0)]
        public void Twos_should_sum_up_all_dice_with_snakeeyes(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Twos, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(1, 2, 3, 4, 3, 6)]
        public void Threes_should_sum_up_all_dice_with_three_eyes(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Three, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }
        
        [TestCase(1, 2, 3, 4, 3, 4)]
        public void Fours_should_sum_up_all_dice_with_four_eyes(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Fours, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(1, 2, 3, 4, 5, 5)]
        public void Fives_should_sum_up_all_dice_with_five_eyes(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Fives, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(1, 2, 6, 4, 5, 6)]
        public void Sixes_should_sum_up_all_dice_with_six_eyes(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Sixes, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(1, 2, 3, 4, 4, 8)]
        [TestCase(2, 2, 2, 5, 5, 10)]
        public void Pair_should_sum_up_the_highest_matching_dice(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.Pair, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        [TestCase(2, 2, 2, 5, 5, 14)]
        public void TwoPair_should_sum_up_both_pairs(int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            AssertScore(YahtzeeCategory.TwoPair, dice1, dice2, dice3, dice4, dice5, expectedScore);
        }

        private void AssertScore(YahtzeeCategory category, int dice1, int dice2, int dice3, int dice4, int dice5, int expectedScore)
        {
            var actualScore = yahtzee.Score(category, dice1, dice2, dice3, dice4, dice5);
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}
