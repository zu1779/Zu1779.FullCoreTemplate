namespace Zu1779.FCT.Presentation.RPGWebMVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Zu1779.FCT.Client.RPGClient;
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
    }
}
