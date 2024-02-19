using CODWloadoutsAPI.Models;
using CODWloadoutsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CODWloadoutsAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeaponsController(IWeaponRepository weaponRepository) : ControllerBase
{
    [HttpGet("Rank")]
    public List<WeaponModel> GetAllWeapons()
    {
        return weaponRepository.GetAllWeaponsRank();
    }
}
