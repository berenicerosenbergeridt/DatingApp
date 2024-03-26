using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[Authorize]
public class UsersController : BaseApiController
{
    private readonly DataContext _context; //champ privé

    public UsersController(DataContext context){
        _context = context;
    }

    [AllowAnonymous]
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
