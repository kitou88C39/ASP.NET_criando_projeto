using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using criando_projeto.Models;

namespace criando_projeto.Controllers;
{
public class TesteController : Controller
{
    private readonly ILogger<TesteController> _logger;

    public TesteController(ILogger<TesteController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Index(string name, string password)
    {
        string receiveName = name;
        string receivePassword = password;
        
        return View();
    }
}
}
