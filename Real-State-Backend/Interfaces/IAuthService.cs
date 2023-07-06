using Real_State_Backend.DTO;
using Real_State_Backend.Services;

namespace Real_State_Backend.Interfaces
{
    public interface IAuthService
    {
        Task<UserResponse> RegisterUser(RegisterDTO user);
    }
}
