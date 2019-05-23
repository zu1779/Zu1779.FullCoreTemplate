namespace Zu1779.FCT.Service.MainServiceAPI.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using Zu1779.FCT.Contract.RPGContract;

    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {
        public CharacterController(ICharacterEngine characterEngine)
        {
            this.characterEngine = characterEngine;
        }
        private readonly ICharacterEngine characterEngine;

        /// <summary>
        /// Generate a single random ability.
        /// </summary>
        /// <returns>Value of the ability [3 - 8]</returns>
        [HttpGet]
        [Route("randomability")]
        public byte RandomAbility()
        {
            return characterEngine.GenerateRandomAbility();
        }

        /// <summary>
        /// Generate some random abilities.
        /// </summary>
        /// <param name="numberOfAbilities">Number of random abilities to generate.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("randomabilities")]
        public List<byte> RandomAbilities(byte numberOfAbilities = 6)
        {
            var abilities = Enumerable.Range(1, numberOfAbilities).Select(c => characterEngine.GenerateRandomAbility()).ToList();
            return abilities;
        }
    }
}
