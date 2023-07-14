using Microsoft.AspNetCore.Mvc;
using Real_State_Backend.DTO;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Services;

namespace Real_State_Backend.Controller
{
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [Route("/register")]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterDTO user)
        {
            if (user == null || user.FullName == null || user.MobileNumber == null || user.Email ==null || user.Password == null)
            {
                return BadRequest();
            }

            var result = await _authService.RegisterUser(user);

            if (!result.IsSuccess)
            {
                return BadRequest();

            }

            return Ok(result);
        }
        [Route("/Login")]
        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginDTO login)
        {
            if (login == null || login.Email==null || login.Password == null)
            {
                return BadRequest();
            }
            var result = await _authService.LoginUser(login);

            if(result.IsSuccess == false)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
