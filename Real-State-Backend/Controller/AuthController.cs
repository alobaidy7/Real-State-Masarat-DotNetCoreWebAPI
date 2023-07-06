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
        public async Task<UserResponse> RegisterUser(RegisterDTO user)
        {
            //if (user == null)
            //{

            //}

            return await _authService.RegisterUser(user);
        }
    }
}
