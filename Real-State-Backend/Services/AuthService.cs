using Microsoft.AspNetCore.Identity;
using Real_State_Backend.DTO;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Models;

namespace Real_State_Backend.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;

        public AuthService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }



        public async Task<UserResponse> RegisterUser(RegisterDTO user)
        {
            var IdentityUser = new User
            {
                Email = user.Email,
                UserName = user.MobileNumber,
                PhoneNumber = user.MobileNumber,
                FullName = user.FullName,
               

            };

            var result = await _userManager.CreateAsync(IdentityUser, user.Password);

            if (result.Succeeded)
            {
                return new UserResponse
                {
                    Message = "User Created Successfully !",
                    IsSuccess = true,

                };
            }

            return new UserResponse
            {
                Message = "User Not Created !",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description)
            };
        }
        public async Task<UserResponse> LoginUser(LoginDTO login)
        {
            var IdentityUser = await _userManager.FindByEmailAsync(login.Email);
            if (IdentityUser == null)
            {
                return new UserResponse
                {
                    Message = "User Not Found",
                    IsSuccess = false,
                };
                
            }
            var result = await _userManager.CheckPasswordAsync(IdentityUser, login.Password);
            if (result == false)
            {
                return new UserResponse
                {
                    Message = "Password Wrong",
                    IsSuccess = false,
                };

            }
            return new UserResponse
            {
                Message = "Login Success",
                IsSuccess = true,
            };
        }
    }
   
   
  
}
