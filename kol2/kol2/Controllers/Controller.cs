using kol2.Context;
using kol2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kol2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Controller : ControllerBase
{
    DbContext _context = new SubscriptionsContext();
    
    [HttpGet("{idClient}")]
    public Client Get(int idClient)
    {
        try
        {
            return Ok());
        }
        catch (ArgumentException exc)
        {
            return BadRequest(exc.Message);
        }
    }


}