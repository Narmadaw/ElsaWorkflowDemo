using Microsoft.AspNetCore.Mvc;

namespace ElsaWorkflowDemo.Controllers
{
    public class ELSA_DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
