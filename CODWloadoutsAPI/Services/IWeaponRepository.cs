using CODWloadoutsAPI.Models;

namespace CODWloadoutsAPI.Services
{
    public interface IWeaponRepository
    {
        List<WeaponModel> GetAllWeaponsRank();
    }
}
