using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Site_1.Areas.Admin.Controllers;

[Area("Admin")]
public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
