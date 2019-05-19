namespace Zu1779.FCT.Business.RPGMainEngine
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    using Zu1779.FCT.Contract.RPGContract;
    using Zu1779.FCT.Contract.RPGContract.Models;

    public class CharacterEngine : ICharacterEngine
    {
        public CharacterEngine(IRNG rng)
        {
            this.rng = rng;
        }
        private readonly IRNG rng;

        public AssemblyName GetVersion() => Assembly.GetExecutingAssembly().GetName();

        public Character GenerateCharacter()
        {
            return new Character();
        }

        
    }
}
