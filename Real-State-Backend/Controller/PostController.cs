using Microsoft.AspNetCore.Mvc;
using Real_State_Backend.DTO;
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
        [HttpPost]
        [Route("/api/createpost")]
        public IActionResult AddPost([FromBody] PostDTO postDTO)
        {
            try
            {
                if (string.IsNullOrEmpty(postDTO.Title)
                    || postDTO.Price == 0
                    || string.IsNullOrEmpty(postDTO.Area)
                    || string.IsNullOrEmpty(postDTO.Description)
                    || string.IsNullOrEmpty(postDTO.Location)
                    || string.IsNullOrEmpty(postDTO.UserId)
                    )
                {
                    return BadRequest("Please Fill all The Required Information (Title,Price,Area,Description,UserID,Location)."); 
                }

                var createdPost = _postservice.AddPost(postDTO);
                return Ok(createdPost); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred."); 
            }
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

        [HttpPut]
        [Route("/api/UpdatePosts")]
        public IActionResult updatePost(int id, PostDTO postDTO)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var post = _postservice.UpdatePost(id, postDTO);

            if (post == null)
            {
                return BadRequest();
            }

            return Ok(post);
        }
    }
}
