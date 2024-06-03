using Microsoft.AspNetCore.Mvc;
using NodeStructure.Models;

namespace NodeStructure.Controllers
{
    public class TreeController : Controller
    {
        public IActionResult Index()
        {
            // Sample data
            var nodes = new List<Node>
            {
                new Node { NodeId = 1, NodeName = "parent-1", ParentNodeId = null, IsActive = true },
                new Node { NodeId = 2, NodeName = "child-1", ParentNodeId = 1, IsActive = true },
                new Node { NodeId = 3, NodeName = "child-2", ParentNodeId = 1, IsActive = true },
                new Node { NodeId = 4, NodeName = "child-1-2", ParentNodeId = 3, IsActive = true },
                new Node { NodeId = 5, NodeName = "parent-2", ParentNodeId = null, IsActive = true },
                new Node { NodeId = 6, NodeName = "child-1", ParentNodeId = 5, IsActive = true },
                new Node { NodeId = 7, NodeName = "child-2", ParentNodeId = 5, IsActive = true }
            };

            return View(nodes);
        }
    }
}
