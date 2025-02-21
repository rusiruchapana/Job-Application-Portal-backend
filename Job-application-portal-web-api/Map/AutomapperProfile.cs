using AutoMapper;
using Job_application_portal_web_api.Dtos.Request;
using Job_application_portal_web_api.Dtos.Response;
using Job_application_portal_web_api.Models;

namespace Job_application_portal_web_api.Map;

public class AutomapperProfile: Profile
{
    public AutomapperProfile()
    {
        CreateMap<JobRequestDto , Job>();
        CreateMap<Job , JobResponseDto>();
    }
}