namespace Zu1779.FCT.Presentation.RPGWebMVC.Controllers
{
    using System;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using m = Zu1779.FCT.Presentation.RPGWebMVC.Models;

    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(m.CharacterModel model)
        {
            if (model.RandomNumber == null) model.RandomNumber = Enumerable.Range(1, 6).Select(c => (byte)c).ToList();
            return View(model);
        }
    }
}
