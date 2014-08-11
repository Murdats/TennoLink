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

        private readonly IWarframeStatusService statusService;

        public HomeController(IMotdService motdService, IWarframeStatusService statusService)
        {
            this.motdService = motdService;
            this.statusService = statusService;
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