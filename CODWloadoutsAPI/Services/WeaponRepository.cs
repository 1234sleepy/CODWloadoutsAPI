using CODWloadoutsAPI.Models;

namespace CODWloadoutsAPI.Services
{
    public class WeaponRepository : IWeaponRepository
    {
        private static List<WeaponModel> weapons;
        public WeaponRepository() 
        {
            weapons = WebScraping.GetWeapon();
        }

        public List<WeaponModel> GetAllWeaponsRank()
        {
            return weapons;
        }
    }
}
