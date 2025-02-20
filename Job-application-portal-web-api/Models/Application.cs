namespace Job_application_portal_web_api.Models;

public class Application
{
    public int Id { get; set; }
    public string ApplicantName { get; set; }
    public string Email { get; set; }
    public string ResumeUrl { get; set; }
    public int JobId { get; set; }
    public Job? Job { get; set; }
}