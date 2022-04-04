using Microsoft.AspNetCore.Mvc;

namespace Navn.Controllers;

[ApiController]
[Route("[controller]")]

public class HighscoreController : ControllerBase
{
    private readonly ILogger<HighscoreController> _logger;

    public HighscoreController(ILogger<HighscoreController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Highscore> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Highscore
        {
            Date = DateTime.Now.AddDays(index),
            Username = "Placeholder",
            Score = 78
        })
        .ToArray();
    }
}