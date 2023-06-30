using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_State_Backend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public string? Location { get; set; }
        public string? Area { get; set; } 
        public bool? Status { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
           
        public ICollection<PostImage>? PostImages { get; set; }  
       
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public DateTime? CreatedTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

    }
}
