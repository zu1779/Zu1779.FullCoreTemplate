namespace Zu1779.FCT.Contract.RPGContract.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represent a character on Star Wars rpg
    /// </summary>
    public class Character
    {
        public Guid Id { get; set; }

        #region Abilities
        public IDictionary<AbilityEnum, byte> Abilities { get; set; } = new Dictionary<AbilityEnum, byte>();
        public byte Strength { get; set; }
        public byte Dexterity { get; set; }
        public byte Constitution { get; set; }
        public byte Intelligence { get; set; }
        public byte Wisdom { get; set; }
        public byte Charisma { get; set; }
        #endregion





        public string Name { get; set; }

        public string @Class { get; set; }

        public string Player { get; set; }

        public string Kind { get; set; }

        public GenderEnum Gender { get; set; }

        public AgeEnum AgeRange { get; set; } = AgeEnum.None;

        /// <summary>
        /// Height of the character in cm.
        /// </summary>
        public short Height { get; set; }

        /// <summary>
        /// Weight in kg.
        /// </summary>
        public short Weight { get; set; }

        public string Description { get; set; }

        public string Background { get; set; }

        public string Personality { get; set; }

        public string Goal { get; set; }

        public string TypicalPhrase { get; set; }

        public IList<CharacterCorrelation> CharacterCorrelation { get; set; }

        #region Features

        #endregion

        /// <summary>Meters per round.</summary>
        public int MovementPerRound { get; set; }

        public bool ForcePerception { get; set; }

        public byte ForcePoint { get; set; }

        public byte ShadowForcePoint { get; set; }

        public byte CharacterPoint { get; set; }

        public HealthEnum Health { get; set; } = HealthEnum.Health;

        public IList<string> SpecialAbility { get; set; }

        public IList<string> Equipment { get; set; }
    }
}
