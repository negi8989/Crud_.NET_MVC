using CrudPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudPage.Controllers
{
    public class NodeController1 : Controller
    {


        private readonly ApiGateway apiGateway;
        public NodeController1(ApiGateway apiGateway)
        {
            this.apiGateway = apiGateway;
        }


        public IActionResult Index()
        {
            List<Node> nodes = new List<Node>();
            nodes = apiGateway.Listnode();
            return View(nodes);

        }

        [HttpGet]
        public IActionResult Create()
        {
            Node node = new Node();
            return View(node);
        }
        [HttpPost]
        public IActionResult Create(Node node)
        {
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            Node node = new Node();
            return View(node);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Node node = new Node();
            return View(node);

        }
        [HttpPost]
        public IActionResult Edit(Node node) { 

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id) {
            Node node = new Node();
            return View(node);

        }
        [HttpPost]
        public IActionResult Delete(Node node) {
            return RedirectToAction("Index");
        }

    }
    
}
