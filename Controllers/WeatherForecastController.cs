using Microsoft.AspNetCore.Mvc;
using static System.IO.File;
namespace meuprimeirocodigoemc_.Controllers;

[ApiController]
[Route("/")]
public class TestController : ControllerBase
{
 [HttpGet]
 public ActionResult OutroTest()

 {
     
     return Content (
         ReadAllText("viws/index.html")  , "text/html");
  }      
}