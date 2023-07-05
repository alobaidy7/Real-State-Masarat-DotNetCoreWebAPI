using Microsoft.AspNetCore.Mvc;
using Real_State_Backend.Interfaces;

namespace Real_State_Backend.Controller
{
    public class PostController : ControllerBase
    {
        private readonly IPostService _postservice;

        public PostController(IPostService postService)
        {

            _postservice = postService;
        }
            [HttpGet]
            [Route("/api/getAll")]
            public IActionResult GetPosts()
            {
                var posts = _postservice.GetAllPosts();
                return Ok(posts);
            
        }
    }
}
