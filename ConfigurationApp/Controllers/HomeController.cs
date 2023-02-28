using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialMediaLinksOptions _options; //assigning the SocialMediaLinksOptions type

        public HomeController(IOptions<SocialMediaLinksOptions> socialMediaLinks)
        {
            _options = socialMediaLinks.Value;
        }

        [Route("/")]    
        public IActionResult Index()
        {
            ViewBag.Facebook = _options.Facebook;
            ViewBag.Twitter = _options.Twitter;
            ViewBag.Youtube = _options.Youtube;
            ViewBag.Instagram = _options.Instagram;


            return View();
        }
    }
}
