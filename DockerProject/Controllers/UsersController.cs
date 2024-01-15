using DockerProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DockerProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;


        public UsersController(IUsersService userService)
        {
            this._usersService = userService;
        }

        [HttpGet(Name = "Get Users") ]
        public async Task<IActionResult> Get()
        {
            var users = await _usersService.GetAllUsers();
            return Ok("All Good");
        }
    }
}
