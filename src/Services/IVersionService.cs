using Roller.Infrastructure.Repository;

namespace Prometheus.Backend.Services;

public interface IVersionService:IServiceBase<Version>
{
    
}

public class VersionService : ServiceBase<Version>, IVersionService
{
    public VersionService(IRepositoryBase<Version> dbContext) : base(dbContext)
    {
    }
}