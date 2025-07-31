using Microsoft.AspNetCore.Mvc;

namespace SetLiszt.Web.Controllers;

public class LibraryController : Controller {

    [Route("/library", Name = "Library")]
    public IActionResult List() {
        return View();
    }

    [Route("/library/upload", Name = "UploadToLibrary")]
    public IActionResult Upload() {
        return View();
    }
}
