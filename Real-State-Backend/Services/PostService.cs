using Microsoft.EntityFrameworkCore;
using Real_State_Backend.Data;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Models;

namespace Real_State_Backend.Services
{
    public class PostService  : IPostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<Post> GetAllPosts()
        {
            var posts = _context.Posts.ToList();
            if (posts == null)
            {
                posts = Array.Empty<Post>().ToList();
                return posts;
            }
            return posts;
        }

        public Post GetPostById(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);
            return post;
        }

    }
}
