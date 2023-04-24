using System.Text.Json.Serialization;

namespace TestTechniqueLAtelier.Models;

public class Root
{
    [JsonPropertyName("players")]
    public List<Player> Players { get; set; }
}