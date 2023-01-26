using Microsoft.AspNetCore.Mvc;
using TransnetWebAPI.Data;
using TransnetWebAPI.Models;
using System.Linq;

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
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        return _context.Users.ToList();

    }
    [HttpGet("{id}")]
    public ActionResult<AppUser> GetUser(int id)
    {
        return _context.Users.Find(id);

    }
}
