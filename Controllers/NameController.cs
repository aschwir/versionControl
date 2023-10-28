
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.Extensions.Logging;



namespace WebApplication1.Controllers
{
  [ApiController]
  [Route("[controller]")]

  public class NameController: ControllerBase
  {

private readonly ILogger<NameController> _logger;

public NameController(ILogger<NameController> logger)
{
  _logger = logger;
}

[HttpGet]

public IActionResult Get()
{
  var personName = new Name{PersonName = "Andrew Schwirinski"};
  return Ok(personName);
  
}
  }
}