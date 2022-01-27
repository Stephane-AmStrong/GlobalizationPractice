using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizationPractice.Controllers
{
    public class InfoController : Controller
    {
        private readonly IStringLocalizer<InfoController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public InfoController(IStringLocalizer<InfoController> localizer, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        public string TestLoc()
        {
            string msg = "Shared resx: " + _sharedLocalizer["Hello!"] + " Info resx " + _localizer["Hello!"];
            return msg;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
