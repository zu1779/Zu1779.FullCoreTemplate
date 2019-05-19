namespace Zu1779.FCT.Contract.RPGContract
{
    public interface IRNG
    {
        int Dice(byte dice = 6, int diceNumber = 1, int discardLessNumber = 0);
        int D6(int diceNumber = 1, int discardLessNumber = 0);
    }
}
