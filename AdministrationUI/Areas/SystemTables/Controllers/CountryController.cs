using AdministrationUI.Constants;
using AdministrationUI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdministrationUI.Areas.SystemTables.Controllers
{
    [Area(AreaNames.SystemTablesArea)]
    public class CountryController : Controller
    {
        private readonly IAuthToken _authToken;

        public CountryController(IAuthToken authToken)
        {
            _authToken = authToken;
        }

     //   public async Task<IActionResult> Index()
        public IActionResult Index()
        {
            ViewBag.AuthToken = " "; // await _authToken.GetToken();
            return View();
        }
    }
}
