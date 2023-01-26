using Microsoft.AspNetCore.Mvc;
using TransnetWebAPI.Data;
using TransnetWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TransnetWebAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataBaseContext _context;

    public UsersController(DataBaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        return await _context.Users.ToListAsync();

    }
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);

    }
}
