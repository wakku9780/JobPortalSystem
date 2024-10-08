namespace JobPortalSystem.Models
{
    public class Employer
    {
        public int EmployerId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        // One-to-Many relationship with Jobs
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }

}
