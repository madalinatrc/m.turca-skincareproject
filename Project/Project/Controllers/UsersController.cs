using IdentityServer3.Core.Services;
using Microsoft.AspNetCore.Mvc;
using SkinCareAPP.Application;

namespace SkinCareAPP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsersController : Controller
    {

        private readonly IUserService userService;

        public object Storage { get; private set; }

        public UsersController(IUserService userService)
        {
            this.userService = userService;

        }
        [HttpGet] // /users
        public IActionResult GetUsers()
        {
            var users = userService.GetAllUsers();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            var user = Storage.User.FirstOrDefault(x => x.Id == id);

            return Ok(user);
        }

        [HttpPost]
        [Route("users")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            var addedUser = this.userService.AddUser(user);

            return Created($"/users/{addedUser.Id}", addedUser);
        }
    }

  }

   
