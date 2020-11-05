using System.Web.Mvc;

namespace StoreFrontLAB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Want to know more about us? Read below!";

            return View();
        }
        
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult Leggings()
        {
            return View();
        }

        public ActionResult Joggers()
        {
            return View();
        }

        public ActionResult Hoodies()
        {
            return View();
        }

        public ActionResult SportsBras()
        {
            return View();
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }

    }
}
