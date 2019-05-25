namespace Zu1779.FCT.Presentation.RPGWebMVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Zu1779.FCT.Client.RPGClient;
    using cm = Zu1779.FCT.Contract.RPGContract.Models;
    using m = Zu1779.FCT.Presentation.RPGWebMVC.Models;

    public class CharacterController : Controller
    {
        public CharacterController(IRPGClient rpgClient)
        {
            this.rpgClient = rpgClient;
        }
        private readonly IRPGClient rpgClient;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Edit(m.CharacterModel model)
        {
            var randomNumber = await rpgClient.RandomAbilitiesAsync(null);
            if (model.RandomNumber == null) model.RandomNumber = new Queue<byte>(randomNumber.Select(c => Convert.ToByte(c)));
            return View(model);
        }

        [HttpPost]
        public IActionResult SetAbility([FromHeader]m.CharacterModel model, cm.AbilityEnum ability)
        {
            var abilityProperty = model.GetType().GetProperty(ability.ToString());
            var abilityValue = (byte)abilityProperty.GetValue(model);
            if (abilityValue != 0)
            {
                model.RandomNumber.Enqueue(abilityValue);
                abilityProperty.SetValue(model, 0);
            }
            else if (model.RandomNumber.Count > 0)
            {
                var value = model.RandomNumber.Dequeue();
                abilityProperty.SetValue(model, value);
            }
            return View("Edit", model);
        }
    }
}
