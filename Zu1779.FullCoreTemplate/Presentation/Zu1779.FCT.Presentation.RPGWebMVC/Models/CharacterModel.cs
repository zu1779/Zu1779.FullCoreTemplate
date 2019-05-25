namespace Zu1779.FCT.Presentation.RPGWebMVC.Models
{
    using System;
    using System.Collections.Generic;

    public class CharacterModel
    {
        public Guid? Id { get; set; }

        #region Abilities
        public byte Strength { get; set; }
        public byte Dexterity { get; set; }
        public byte Constitution { get; set; }
        public byte Intelligence { get; set; }
        public byte Wisdom { get; set; }
        public byte Charisma { get; set; }
        #endregion

        public Queue<byte> RandomNumber { get; set; }
    }
}