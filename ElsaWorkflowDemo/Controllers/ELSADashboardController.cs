using Microsoft.AspNetCore.Mvc;

namespace ElsaWorkflowDemo.Controllers
{
    public class ELSADashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
