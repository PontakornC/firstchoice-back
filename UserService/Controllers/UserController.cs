using Microsoft.AspNetCore.Mvc;
using UserService.Entity;
using UserService.Services;

namespace UserService.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class UserController : Controller
    {
        private readonly UserServices _userService;
        private readonly dbContext _db;
        public UserController(UserServices userService,dbContext dbContext)
        {
            _userService = userService;
            _db = dbContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _db.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _db.Users.FirstOrDefault(r=>r.Id == id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
    }
}
