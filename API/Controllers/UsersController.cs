using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController] 
[Route("api/[controller]")] //API USERS : 
public class UsersController : ControllerBase
{
    private readonly DataContext _context; //champ privé

    public UsersController(DataContext context){
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //liste des utilisateurs
    {
        var users = await _context.Users.ToListAsync(); //affiche la liste des utilisateurs 
        return users; //afficher
    }    

    [HttpGet("{id}")] // /api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id) //def qui récupère l'utilisateur en ligne
    {
        return await _context.Users.FindAsync(id);
    }
}
