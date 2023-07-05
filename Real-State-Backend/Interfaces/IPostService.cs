using Real_State_Backend.Models;

namespace Real_State_Backend.Interfaces
{
    public interface IPostService
    {
        public ICollection<Post> GetAllPosts();
       

    }
}
