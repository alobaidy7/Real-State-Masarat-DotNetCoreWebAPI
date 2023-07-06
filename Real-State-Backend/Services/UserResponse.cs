namespace Real_State_Backend.Services
{
    public class UserResponse
    {
        public string? Message { get; set; }
        public bool IsSuccess { get; set;}
        public IEnumerable<string>? Errors { get; set;}
        public DateTime ResponedAt { get; set;} = DateTime.Now;
    }
}
