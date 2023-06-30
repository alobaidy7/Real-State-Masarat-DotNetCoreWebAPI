using System.ComponentModel.DataAnnotations.Schema;

namespace Real_State_Backend.Models
{
    public class PostImage
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        
        public int PostId { get; set; }
        public Post Post { get; set; }

    } 
}
