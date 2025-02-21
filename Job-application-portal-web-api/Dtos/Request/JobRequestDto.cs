namespace Job_application_portal_web_api.Dtos.Request;

public class JobRequestDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Company { get; set; }
    public string Location { get; set; }
    public decimal Salary { get; set; }
}