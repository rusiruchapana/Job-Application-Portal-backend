using Job_application_portal_web_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Job_application_portal_web_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobController: ControllerBase
{
    private readonly IJobService _jobService;
    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }
    
    
    
    
    
}