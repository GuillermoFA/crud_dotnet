namespace apinet.Src.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Entity Framework Core Relationships
        public List<Interest> Interests { get; set; } = new();

        public List<Framework> Frameworks { get; set; } = new();

        public List<SocialNetwork> SocialNetworks { get; set; } = new();


    }
}