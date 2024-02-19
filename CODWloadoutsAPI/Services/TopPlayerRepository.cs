using CODWloadoutsAPI.Models;

namespace CODWloadoutsAPI.Services
{
    public class TopPlayerRepository : ITopPlayerRepository
    {
        private static List<TopPlayer> topPlayers;
        public TopPlayerRepository() 
        {
            topPlayers = WebScraping.GetTopPlayer();
        }

        public List<TopPlayer> GetTopPlayers()
        {
            return topPlayers;
        }
    }
}
