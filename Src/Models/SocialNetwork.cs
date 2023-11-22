namespace apinet.Src.Models
{
    public class SocialNetwork
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        // Entity Framework Core Relationships
        public User User { get; set; } = null!;
        public int UserId { get; set; }
        
    }
}