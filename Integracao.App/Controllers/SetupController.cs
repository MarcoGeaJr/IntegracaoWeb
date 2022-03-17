using Integracao.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Integracao.App.Controllers
{
    /// <summary>
    /// O Setup Controller é responsável por direcionar a requisição ao Setup service, que fará o consumo da API.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles ="admin")]
    public class SetupController : MainController
    {
        private readonly ISetupService _setupService;

        public SetupController(INotificationService notificationService, ISetupService setupService)
            :base(notificationService)
            => _setupService = setupService;

        [HttpPost]
        public async Task<IActionResult> Setup()
        {
            try
            {
                return CustomResponse(await _setupService.Setup());
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
                
        }
    }
}
