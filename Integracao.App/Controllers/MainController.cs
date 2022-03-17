using Integracao.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Integracao.App.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        protected MainController(INotificationService notificationService)
            => _notificationService = notificationService;

        protected ActionResult CustomResponse(object result = null)
        {
            try
            {
                if (!_notificationService.hasError())
                    return Ok();
                else
                {
                    var error = _notificationService.GetErrors();

                    if (error.StatusCode == HttpStatusCode.NotFound)
                        return NotFound(new { error = error.Message });
                    else if (error.StatusCode == HttpStatusCode.Unauthorized)
                        return Unauthorized(new { error = error.Message });
                    else
                        return BadRequest(new { error = error.Message });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    sucesso = false,
                    error = new List<string> { ex.ToString() }
                });
            }
        }
    }
}
