﻿using Real_State_Backend.DTO;
using Real_State_Backend.Models;

namespace Real_State_Backend.Interfaces
{
    public interface IPostService
    {
        public ICollection<Post> GetAllPosts();
        public Post GetPostById(int id);
        public ICollection<Post> DeletePost(int id);
        public Post AddPost(PostDTO postDTO);
        public Post UpdatePost(int id, PostDTO postDTO);



    }
}
