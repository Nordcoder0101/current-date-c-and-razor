using Microsoft.AspNetCore.Mvc;

namespace current_time
{
  public class IndexController : Controller
  {
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
    
      return View();
    }
  }
}