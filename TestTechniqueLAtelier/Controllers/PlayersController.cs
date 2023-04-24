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
    
    [HttpGet("/{id:int}")]
    public ActionResult<Player> GetPlayerById(int id)
    {
        try {
            return _playersService.GetPlayerById(id);
        }
        catch (InvalidOperationException) {
            return NotFound();
        }
    }
    
    [HttpGet("/getCountryWithMostGameRatioWon")]
    public ActionResult<Country> GetCountryWithMostGameRatioWon()
    {
        try {
            return _playersService.GetCountryWithMostGameRatioWon();
        }
        catch (InvalidOperationException) {
            return NotFound();
        }
    }
    
    [HttpGet("/getAveragesBmiOfPlayers")]
    public ActionResult<double> GetAveragesBmiOfPlayers()
    {
        return _playersService.GetAveragesBMIOfPlayers();
    }
    
    [HttpGet("/getMedianSizeOfPlayers")]
    public ActionResult<double> GetMedianSizeOfPlayers()
    {
        return _playersService.GetMedianSizeOfPlayers();
    }
}