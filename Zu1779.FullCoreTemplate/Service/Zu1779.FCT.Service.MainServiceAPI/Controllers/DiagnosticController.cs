namespace Zu1779.FCT.Service.MainServiceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Zu1779.FCT.Contract.RPGContract;

    public class DiagnosticController : ControllerBase
    {
        public DiagnosticController(ICharacterEngine characterEngine)
        {
            this.characterEngine = characterEngine;
        }
        private readonly ICharacterEngine characterEngine;

        public JsonResult GetVersion() => new JsonResult(Assembly.GetExecutingAssembly().GetName());

        public JsonResult GetRpgVersion() => new JsonResult(characterEngine.GetVersion());
    }
}
