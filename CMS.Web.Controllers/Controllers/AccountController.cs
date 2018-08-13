using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CMS.Web.Controllers.Controllers
{
    public class AccountController: Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}
