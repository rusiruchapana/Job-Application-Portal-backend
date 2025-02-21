namespace Job_application_portal_web_api.Dtos.Request;

public class ApplicationRequestDto
{
    public string ApplicantName { get; set; }
    public string Email { get; set; }
    public string ResumeUrl { get; set; }
    public int JobId { get; set; }
}