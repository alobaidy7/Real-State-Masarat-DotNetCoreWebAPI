using Microsoft.EntityFrameworkCore;
using Real_State_Backend.Data;
using Real_State_Backend.DTO;
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
       
        public Post AddPost(PostDTO postDTO)
        {
          

            var post = new Post
            {
                Title = postDTO.Title,
                Price = postDTO.Price,
                Area = postDTO.Area,
                UserId= postDTO.UserId,
                Description = postDTO.Description,
                Location = postDTO.Location,
                Status = postDTO.Status,
                Category = postDTO.Category,
                SubCategory = postDTO.SubCategory,
            };

            _context.Posts.Add(post);
            _context.SaveChanges();

            return post;
        }
        public ICollection<Post> DeletePost(int id)
        {
            var post = _context.Posts.FirstOrDefault(p=> p.Id == id);
            if (post == null)
            {
                return _context.Posts.ToList();
            }
            _context.Remove(post);
            _context.SaveChanges();
            return _context.Posts.ToList();
        }

        public Post UpdatePost(int id, PostDTO postDTO)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            post.Id = id;
            post.Title = postDTO.Title;
            post.Description = postDTO.Description;
            post.Location = postDTO.Location;
            post.Status = postDTO.Status;
            post.Category = postDTO.Category;
            post.SubCategory = postDTO.SubCategory;
            post.Price = postDTO.Price;
            post.Area = postDTO.Area;
            

            _context.Posts.Add(post);
            _context.Posts.Update(post);
            _context.SaveChanges();

            return post;
        }

    }
}
