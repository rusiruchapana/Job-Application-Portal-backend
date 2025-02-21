using Job_application_portal_web_api.Models;

namespace Job_application_portal_web_api.Repositories;

public interface IJobRepository
{
    Task<Job> CreateJob(Job job);
    Task<List<Job>> AllJobs();
}