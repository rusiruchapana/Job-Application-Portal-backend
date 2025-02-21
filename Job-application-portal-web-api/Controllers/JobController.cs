using Job_application_portal_web_api.Dtos.Request;
using Job_application_portal_web_api.Dtos.Response;
using Job_application_portal_web_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Job_application_portal_web_api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class JobController: ControllerBase
{
    private readonly IJobService _jobService;
    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateJob(JobRequestDto jobRequestDto)
    {
        JobResponseDto jobResponseDto = await _jobService.CreateJob(jobRequestDto);
        return Ok(jobResponseDto);
    }



}