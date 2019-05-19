namespace Zu1779.FCT.Business.RPGMainEngine
{
    using System;
    using System.Linq;

    using Zu1779.FCT.Contract.RPGContract;
    public class RNG : IRNG
    {
        private static Random rng = new Random();

        public int Dice(byte dice = 6, int diceNumber = 1, int discardLessNumber = 0)
        {
            var rolls = Enumerable.Range(1, diceNumber).Select(c =>rng.Next(0, dice) + 1)
                .OrderBy(c => c).Skip(discardLessNumber).ToList();
            return rolls.Sum();
        }
        public int D6(int diceNumber = 1, int discardLessNumber = 0) => Dice(6, diceNumber, discardLessNumber);
    }
}
