using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[Authorize]
public class UsersController : BaseApiController
{
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

    public UsersController(IUserRepository userRepository, IMapper mapper){
            _mapper = mapper;
            _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers() //liste des utilisateurs
    {
        var users = await _userRepository.GetMembersAsync(); //affiche la liste des utilisateurs
        return Ok(users);

    }   

    [HttpGet("{username}")] // /api/users/2
    public async Task<ActionResult<MemberDto>> GetUser(string username) //def qui récupère l'utilisateur en ligne
    {
        return await _userRepository.GetMemberAsync(username);
    }
}