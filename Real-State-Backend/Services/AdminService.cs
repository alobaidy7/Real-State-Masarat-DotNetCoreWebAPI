using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Real_State_Backend.Data;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Models;

namespace Real_State_Backend.Services
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _context;

        public AdminService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var result = await _context.Users.ToListAsync();
          
            return result;
        }



        public async Task<User> GetUserById(string? id)
        {
            var result = _context.Users.FirstOrDefault(e => e.Id == id);

            return result;
        }

    }
}
