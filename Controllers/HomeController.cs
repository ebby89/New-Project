using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Parcel.Controllers
{
    public class HomeController : Controller
    {
      [Route("/parcel")]
      public ActionResult Parcel()
      {
        return View();
      }

      [Route("/results")]
      public ActionResult Results()
      {
        Dimensions myDimensions = new Dimensions();
        myDimensions.SetLength(Request.Query["length"]);
        myDimensions.SetWidth(Request.Query["width"]);
        myDimensions.SetHeight(Request.Query["height"]);
        myDimensions.SetWeight(Request.Query["weight"]);
        return View(myDimensions);
      }
    }
}
