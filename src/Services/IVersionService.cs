using Roller.Infrastructure.Repository;

namespace Prometheus.Backend.Services;

public interface IVersionService:IServiceBase<Version>
{
    
}

public class VersionService(IRepositoryBase<Version> dbContext) : ServiceBase<Version>(dbContext), IVersionService;