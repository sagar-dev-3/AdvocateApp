using AdvocateApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdvocateApp.Controllers
{
    /// <summary>
    /// Lightweight API exposing static site content as JSON.
    /// Frontend is fully functional without these endpoints.
    /// </summary>
    [ApiController]
    [Route("api/site")]
    public class SiteController : ControllerBase
    {
        private readonly SiteContent _content;

        public SiteController(SiteContent content)
        {
            _content = content;
        }

        /// <summary>GET /api/site/profile – Returns advocate profile data.</summary>
        [HttpGet("profile")]
        public IActionResult GetProfile() => Ok(_content.Profile);

        /// <summary>GET /api/site/practice-areas – Returns all practice areas.</summary>
        [HttpGet("practice-areas")]
        public IActionResult GetPracticeAreas() => Ok(_content.PracticeAreas);

        /// <summary>GET /api/site/services – Returns all legal services.</summary>
        [HttpGet("services")]
        public IActionResult GetServices() => Ok(_content.Services);
    }
}
