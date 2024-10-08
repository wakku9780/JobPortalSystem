using System.Text.Json.Serialization;

namespace JobPortalSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ExperienceLevel { get; set; }
        public string Location { get; set; }
        public string Skills { get; set; }

        // One-to-Many relationship with Applications

        [JsonIgnore]
        // One-to-Many relationship with Applications
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }

}
