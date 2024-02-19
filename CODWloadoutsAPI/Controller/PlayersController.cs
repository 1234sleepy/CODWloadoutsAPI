using CODWloadoutsAPI.Models;
using CODWloadoutsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CODWloadoutsAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController(ITopPlayerRepository topPlayerRepository) : ControllerBase
{
    [HttpGet("TopPlayers")]
    public List<TopPlayer> GetTopPlayers()
    {
        return topPlayerRepository.GetTopPlayers();
    }
}
