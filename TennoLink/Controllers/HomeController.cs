using System;
using System.Linq;
using System.Web.Mvc;
using TennoLink.Services.Interfaces;
using TennoLink.ViewModels;

namespace TennoLink.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMotdService motdService;

        public HomeController(IMotdService motdService)
        {
            this.motdService = motdService;
        }

        public ActionResult Index()
        {
            var viewModel = new TennoLinkViewModel
            {
                Motd = motdService.GetMotdHtml()
            };

            return View(viewModel);
        }
    }
}