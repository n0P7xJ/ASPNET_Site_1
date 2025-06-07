using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Site_1.Areas.Admin.Controllers;

[Area("Admin")]
public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
