using AutoMapper;
using Job_application_portal_web_api.Dtos.Request;
using Job_application_portal_web_api.Dtos.Response;
using Job_application_portal_web_api.Models;
using Job_application_portal_web_api.Repositories;

namespace Job_application_portal_web_api.Services.impl;

public class JobService: IJobService
{
    private readonly IJobRepository _jobRepository;
    private readonly IMapper _mapper;

    public JobService(IJobRepository jobRepository , IMapper mapper)
    {
        _jobRepository = jobRepository;
        _mapper = mapper;
    }

    public async Task<JobResponseDto> CreateJob(JobRequestDto jobRequestDto)
    {
        Job job = await _jobRepository.CreateJob(_mapper.Map<Job>(jobRequestDto));
        return _mapper.Map<JobResponseDto>(job);
    }

    public async Task<List<JobResponseDto>> AllJobs()
    {
        List<Job> jobs = await _jobRepository.AllJobs();
        return _mapper.Map<List<JobResponseDto>>(jobs);
    }

    public async Task<JobResponseDto> GetJobById(int id)
    {
        Job job = await _jobRepository.GetJobById(id);
        JobResponseDto jobResponseDto = _mapper.Map<JobResponseDto>(job);
        return jobResponseDto;
    }
}