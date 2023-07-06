using Microsoft.AspNetCore.Mvc;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Models;

namespace Real_State_Backend.Controller
{

    [Route("/api/admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<List<User>> GetAllUsers()
        {
            var result = await _adminService.GetAllUsers();
            return result;
        }

        [HttpGet]
        public async Task<User> GetUserById(string? id)
        {
            var result = await _adminService.GetUserById(id);
            return result;
        }
    }
}
