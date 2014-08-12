using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountTraker.Data;
using AccountTraker.Models;

namespace AccountTraker.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            AccountDataService accountDataService = new AccountDataService();

            AccountsJsonModel data = accountDataService.GetAccountData(Server.MapPath("~/App_Data/2014-data.json"));

            return View();
        }

    }
}
