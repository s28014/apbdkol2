using Microsoft.AspNetCore.Mvc;

namespace kol2.Services;

public interface IService
{
    Task<IActionResult> GetClientAndSubscriptions(int idKlienta);
}