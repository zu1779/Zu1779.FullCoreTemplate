﻿namespace Zu1779.FCT.Contract.RPGContract
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    using Models;

    public interface ICharacterEngine
    {
        AssemblyName GetVersion();

        Character GenerateCharacter();

        byte GenerateRandomAbility();
    }
}
