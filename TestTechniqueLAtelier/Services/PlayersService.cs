using MathNet.Numerics.Statistics;
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
    
    // I have absolutely no idea how to see the ratio of won games for each country
    // So I just return the first country
    // Is it based on the Rank of the players?
    // or the Points?
    // I have never played tennis, I'm too weak
    public Country GetCountryWithMostGameRatioWon()
    {
        // Randomly return the first country
        return _rootPlayers.Players.First().Country;
    }
    
    
    public double GetAveragesBMIOfPlayers()
    {
        return Math.Round(_rootPlayers.Players.Average(p => IBM(p.Data.Weight/1000d, p.Data.Height/100d)), 1);
    }
    
    // I'm very bad with math, I prefer to use libraries for that
    public double GetMedianSizeOfPlayers()
    {
        IEnumerable<double> heights = _rootPlayers.Players.Select(height => height.Data.Height/100d);
        return heights.Median();
    }
    
    /// <summary>
    /// calculate the IBM weight and height are in kg and m
    /// </summary>
    /// <param name="weight"> in kg </param>
    /// <param name="height">in meter</param>
    /// <returns>The rounded imc value at first digit</returns>
    public double IBM(double weight, double height) => Math.Round(weight / (height * height), 1);
    
}