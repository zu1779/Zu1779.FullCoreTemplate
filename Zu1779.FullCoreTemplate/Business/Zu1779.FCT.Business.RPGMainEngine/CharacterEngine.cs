namespace Zu1779.FCT.Business.RPGMainEngine
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    using Zu1779.FCT.Contract.RPGContract;

    public class CharacterEngine : ICharacterEngine
    {
        public AssemblyName GetVersion() => Assembly.GetExecutingAssembly().GetName();
    }
}
