using Microsoft.AspNetCore.Mvc;

namespace scoi.Controllers
{
    public abstract class ViewController : Controller
    {
        private static string js_comon_version = "1";

        public ViewResult Matrix()
        {
            return getDefaultViewResult();
        }

        public ViewResult Fur()
        {
            return getDefaultViewResult();
        }

        public ViewResult Index()
        {
            return getDefaultViewResult();
        }

        public ViewResult Binary()
        {
            return getDefaultViewResult();
        }
        public ViewResult Median()
        {
            return getDefaultViewResult();
        }

        protected ViewResult getDefaultViewResult()
        {
            ViewBag.jsversion = js_comon_version;
            return View();
        }

        public ViewResult LogoGen()
        {
            return View("vLogoGen");
        }
    }
}
