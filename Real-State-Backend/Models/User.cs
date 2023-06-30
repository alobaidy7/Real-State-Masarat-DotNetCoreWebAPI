using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_State_Backend.Models
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        // باقي التفاصيل موجودة في جدول الايدنتتي
        public string? ProfileImage { get; set; } = "https://www.transparentpng.com/thumb/user/gray-user-profile-icon-png-fP8Q1P.png";
     
        public ICollection<Post>? Posts { get; set; }
        
    }
}
