using Microsoft.AspNetCore.Mvc;
using Real_State_Backend.Interfaces;
using Real_State_Backend.Services;

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

        [HttpGet]
        [Route("/api/getPostById")]
        public IActionResult GetPostById(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var post = _postservice.GetPostById(id);

            return Ok(post);
        }
        [HttpDelete]
        [Route("/api/Delete")]
        public IActionResult DeletePost(int id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var post= _postservice.DeletePost(id);
            return Ok(post);
        }
    }
}
