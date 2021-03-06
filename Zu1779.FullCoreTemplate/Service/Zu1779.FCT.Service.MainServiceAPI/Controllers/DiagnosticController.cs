﻿namespace Zu1779.FCT.Service.MainServiceAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;

    using Zu1779.FCT.Contract.RPGContract;

    [ApiController]
    [Route("api/diagnostic")]
    public class DiagnosticController : ControllerBase
    {
        public DiagnosticController(ICharacterEngine characterEngine, ILogger<DiagnosticController> logger)
        {
            this.characterEngine = characterEngine;
            this.logger = logger;
        }
        private readonly ICharacterEngine characterEngine;
        private readonly ILogger<DiagnosticController> logger;

        /// <summary>
        /// Get the version of the hosting api.
        /// </summary>
        [HttpGet]
        [Route("getversion")]
        public IActionResult GetVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            logger.LogInformation($"Get version returned: {JsonConvert.SerializeObject(assemblyName)}");
            var response = new JsonResult(assemblyName);
            return response;
        }

        /// <summary>
        /// Get the version of the Rpg Engine.
        /// </summary>
        [HttpGet]
        [Route("getrpgversion")]
        public IActionResult GetRpgVersion() => new JsonResult(characterEngine.GetVersion());

        /// <summary>
        /// Throw a generic critical exception.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("testexception")]
        public IActionResult TestException()
        {
            try
            {
                throw new ApplicationException("Test exception");
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex, "Critical exception");
                throw;
            }
        }
    }
}
