using Configuration.Library.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Configuration.WebApi.Controllers
{
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationService _configurationService;

        public ConfigurationController(IConfigurationService configurationService )
        {
            _configurationService = configurationService;
        }

        [Route("/api/GetApiUrls")]
        [HttpGet]
        public IActionResult GetApiUrls()
        {
            try
            {
                return new JsonResult(_configurationService.GetApiUrls());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}