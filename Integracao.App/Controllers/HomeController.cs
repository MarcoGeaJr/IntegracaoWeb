using Integracao.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Integracao.App.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ISetupService _setup;

        public HomeController(ISetupService setup)
        {
            _setup = setup;
        }
    }
}
