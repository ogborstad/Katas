using System;
using System.Linq;

namespace YatzeeKataTests
{
    public enum YahtzeeCategory
    {
        Chance,
        Ones,
        Twos,
        Three,
        Fours,
        Fives,
        Sixes,
        Pair,
        TwoPair
    }
    
    public class Yahtzee
    {
        public int Score(YahtzeeCategory category, params int[] dice)
        {
            if (category == YahtzeeCategory.Chance) return dice.Sum();
            if (category == YahtzeeCategory.Ones) return SumDiceWithEye(dice, 1);
            if (category == YahtzeeCategory.Twos) return SumDiceWithEye(dice, 2);
            if (category == YahtzeeCategory.Three) return SumDiceWithEye(dice, 3);
            if (category == YahtzeeCategory.Fours) return SumDiceWithEye(dice, 4);
            if (category == YahtzeeCategory.Fives) return SumDiceWithEye(dice, 5);
            if (category == YahtzeeCategory.Sixes) return SumDiceWithEye(dice, 6);
            if (category == YahtzeeCategory.Pair) return SumHighestPair(dice);
            if (category == YahtzeeCategory.TwoPair) return SumTwoPairs(dice);

            return 0;
        }

        private int SumDiceWithEye(int[] dice, int eyeToBeSummed)
        {
            return dice.Where(d => d == eyeToBeSummed).Sum();
        }

        private int SumHighestPair(int[] dice)
        {
            var eyeOfGreatestPair = dice.GroupBy(d => d)
                                        .Where(g => g.Count() > 1)
                                        .OrderByDescending(g => g.Key)
                                        .Select(g => g.Key)
                                        .First();
            return eyeOfGreatestPair * 2;
        }

        private int SumLowestPair(int[] dice)
        {
            var eyeOfSmallestPair = dice.GroupBy(d => d)
                                        .Where(g => g.Count() > 1)
                                        .OrderBy(g => g.Key)
                                        .Select(g => g.Key)
                                        .First();
            return eyeOfSmallestPair * 2;
        }

        private int SumTwoPairs(int[] dice)
        {
            return SumHighestPair(dice) + SumLowestPair(dice);
        }
    }
}