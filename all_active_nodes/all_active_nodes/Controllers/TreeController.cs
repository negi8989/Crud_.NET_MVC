using all_active_nodes.Data;
using Microsoft.AspNetCore.Mvc;

namespace all_active_nodes.Controllers
{
    public class TreeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TreeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ActiveNodes()
        {
            var nodes = await _context.GetActiveNodesAsync();
            return View(nodes);
        }
    }
}
 