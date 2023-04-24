using System.Text.Json;
using Newtonsoft.Json;
using TestTechniqueLAtelier.Models;

namespace TestTechniqueLAtelier.Services;

public class PlayersService : IPlayersService
{
    private Root _rootPlayers = new();

    public PlayersService()
    {
        InitializePlayers();
    }

    private void InitializePlayers()
    {
        var json = File.ReadAllText("data/headtohead.json");
        _rootPlayers = JsonConvert.DeserializeObject<Root>(json) ?? throw new InvalidOperationException();
    }

    public IEnumerable<Player> GetPlayersOrderedByScore()
    {
        return _rootPlayers.Players.OrderByDescending(p => p.Data.Points).ToList();
    }
    
    public Player GetPlayerById(int id)
    {
        return _rootPlayers.Players.First(p => p.Id == id);
    }
}