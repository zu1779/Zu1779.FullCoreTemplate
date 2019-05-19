namespace Zu1779.FCT.Contract.RPGContract.Models
{
    using System;

    [Flags]
    public enum AbilityEnum : byte
    {
        None = 0,
        Strength = 1,
        Dexterity = 2,
        Constitution = 4,
        Intelligence = 8,
        Wisdom = 16,
        Charisma = 32,
    }
}
