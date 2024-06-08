using FC.Exercicios.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FC.Exercicios.API.Controllers
{
    [ApiController]
    [Route("api/settings")]
    public class SettingsController : ControllerBase
    {
        private readonly IConfigurationService _configurationService;
        public SettingsController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet]
        public ActionResult<Dictionary<string, string>> GetSettings()
        {
            var settings = _configurationService.GetSettings();
            return Ok(settings);
        }

        [HttpPost]
        public ActionResult UpdateSettings([FromBody] Dictionary<string, string> newSettings)
        {
            if (newSettings == null)
            {
                return BadRequest("Settings data must be provided.");
            }


            _configurationService.UpdateSettings(newSettings);
            return Ok("Atualização feita com sucesso");
        }
    }
}
