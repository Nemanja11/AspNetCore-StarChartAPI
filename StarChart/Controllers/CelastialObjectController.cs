using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route(" ")]
    [ApiController]
    public class CelastialObjectController : ControllerBase

    {
        private readonly ApplicationDbContext _context;

        public CelastialObjectController(ApplicationDbContext context)
        {
            context=_context;
        }

        
    }
}