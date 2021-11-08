using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwoomBackEnd.DTOs;
using SwoomBackEnd.Service.IService;

namespace SwoomBackEnd.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        //comment
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet("/[action]")]
        public UserDTO GetUserById(int userId)
        {
            return _userService.GetUserById(userId);
        }
    }
}