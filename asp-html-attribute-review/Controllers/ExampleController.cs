using Microsoft.AspNetCore.Mvc;

namespace asp_html_attribute_review.Controllers
{
    public class ExampleController : Controller
    {
        // this method handles GET requests made at /example/index
        public IActionResult Index()
        {
            return View();
        }

        // routed to GET requests at /example/data
        // no need to specify http method and route when the method name matches the route name
        // [HttpGet]
        // [Route("/data")]
        public IActionResult Data(string foo)
        {
            ViewBag.foo = foo;
            return View();
        }

        [HttpPost]
        public IActionResult FormHandler(string name)
        {

            ViewBag.name = name;

            // have this FormHandler rerender /example/index
            return View("Index");
        }
    }
}
