namespace Job_application_portal_web_api.Dtos.Response;

public class ApplicationResponseDto
{
    public int Id { get; set; }
    public string ApplicantName { get; set; }
    public string Email { get; set; }
    public string ResumeUrl { get; set; }
    public int JobId { get; set; }
}