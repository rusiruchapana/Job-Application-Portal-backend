namespace Job_application_portal_web_api.Models;

public class Job
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Company { get; set; }
    public string Location { get; set; }
    public decimal Salary { get; set; }
    public DateTime PostedDate { get; set; } = DateTime.Now;
}