using Microsoft.AspNetCore.Mvc;
using Real_State_Backend.Models;

namespace Real_State_Backend.Interfaces
{
    public interface IAdminService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(string? id);

    }
}
