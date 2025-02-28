using Job_application_portal_web_api.Dtos.Request;
using Job_application_portal_web_api.Dtos.Response;

namespace Job_application_portal_web_api.Services;

public interface IJobService
{
    Task<JobResponseDto> CreateJob(JobRequestDto jobRequestDto);
    Task<List<JobResponseDto>> AllJobs();
    Task<JobResponseDto> GetJobById(int id);
}