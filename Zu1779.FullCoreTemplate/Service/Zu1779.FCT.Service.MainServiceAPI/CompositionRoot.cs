namespace Zu1779.FCT.Service.MainServiceAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LightInject;

    using Zu1779.FCT.Business.RPGMainEngine;
    using Zu1779.FCT.Contract.RPGContract;

    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<ICharacterEngine, CharacterEngine>(new PerScopeLifetime());
        }
    }
}
