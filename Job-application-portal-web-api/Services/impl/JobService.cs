using Job_application_portal_web_api.Dtos.Request;
using Job_application_portal_web_api.Dtos.Response;
using Job_application_portal_web_api.Repositories;

namespace Job_application_portal_web_api.Services.impl;

public class JobService: IJobService
{
    private readonly IJobRepository _jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<JobResponseDto> CreateJob(JobRequestDto jobRequestDto)
    {
        return null;
    }
}