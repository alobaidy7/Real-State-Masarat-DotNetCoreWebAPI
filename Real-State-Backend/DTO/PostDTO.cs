using Real_State_Backend.Models;

namespace Real_State_Backend.DTO
{
    public class PostDTO
    {
        
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public string? Location { get; set; }
        public string? Area { get; set; }
        public bool? Status { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? UserId { get; set; }
        public string? ImageURL { get; set; }



    }
}
