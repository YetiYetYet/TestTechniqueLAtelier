using Microsoft.AspNetCore.Mvc;
using TestTechniqueLAtelier.Models;
using TestTechniqueLAtelier.Services;

namespace TestTechniqueLAtelier.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
    private readonly IPlayersService _playersService;

    public PlayersController(IPlayersService playersService)
    {
        _playersService = playersService;
    }
    
    
    [HttpGet("/orderedbyScore")]
    public ActionResult<IEnumerable<Player>> GetPlayersOrderedByScore()
    {
        return _playersService.GetPlayersOrderedByScore().ToList();
    }
    
    // [HttpGet("/player/{id}")]
    // public ActionResult<Player> GetPlayerById(int id)
    // {
    //     return _playersService.GetPlayerById(id);
    // }
}