namespace apinet.Src.Models
{
    public class Framework
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Entity Framework Core Relationships
        public User User { get; set; } = null!;
        public int UserId { get; set; }


        
    }
}