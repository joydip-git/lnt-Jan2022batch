using Microsoft.AspNetCore.Mvc;

namespace SecondMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        ///Home/SayHi/...
        public string SayHi(string id = null)
        {
            if (id != null)
                return id;
            else
                return "welcome to asp.net core mvc";
        }

        //Home/Index
        public ViewResult Index()
        {
            ViewResult indexView = this.View();
            return indexView;
        }
    }
}
