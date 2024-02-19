using CODWloadoutsAPI.Models;

namespace CODWloadoutsAPI.Services
{
    public interface ITopPlayerRepository
    {
        List<TopPlayer> GetTopPlayers();
    }
}
