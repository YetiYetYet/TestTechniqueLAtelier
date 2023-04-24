using TestTechniqueLAtelier.Models;

namespace TestTechniqueLAtelier.Services;

public interface IPlayersService
{
    public IEnumerable<Player> GetPlayersOrderedByScore();
    public Player GetPlayerById(int id);
    public Country GetCountryWithMostGameRatioWon();
}