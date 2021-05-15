using Microsoft.AspNetCore.Mvc;
using RemoteAgent.Constants;
using RemoteAgent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAgent.Areas.SystemTables.Controllers
{
    [Area(AreaNames.SystemTablesArea)]
    public class TableAdminController : Controller
    {
        private readonly IAuthToken _authToken;

        public TableAdminController(IAuthToken authToken)
        {
            _authToken = authToken;
        }

        //   public async Task<IActionResult> Index()
        public IActionResult Index(string title, string apicall)
        {
            ViewBag.Title = title;
            ViewBag.ApiCall = apicall;
            ViewBag.AuthToken = " "; // await _authToken.GetToken();
            return View();
        }
    }
}
