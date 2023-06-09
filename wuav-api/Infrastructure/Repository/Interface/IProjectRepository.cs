using wuav_api.Domain.Model;

namespace wuav_api.Infrastructure.Repository.Interface;

public interface IProjectRepository
{
    Task<Project> GetAllProjectsByUserIdAsync(string userId);
}