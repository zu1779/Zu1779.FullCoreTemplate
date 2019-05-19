namespace Zu1779.FCT.Contract.RPGContract.Models
{
    using System;

    public class CharacterCorrelation
    {
        public Guid WhoKnowsId { get; set; }

        public Guid KnownId { get; set; }

        public string Description { get; set; }
    }
}
