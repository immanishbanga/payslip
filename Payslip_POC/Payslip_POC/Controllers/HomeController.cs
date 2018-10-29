using BusinessLayer;
using Common;
using System.Web.Mvc;

namespace Payslip_POC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult PaySlip(Employee model)
        {
            return PartialView("_PaySlip", new PayslipManager().GeneratePaySlip(model));
        }
    }
}