using Microsoft.AspNetCore.Mvc;

namespace CpaClientManager.Core.Controllers;

public sealed class HomeController : Controller
{
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}