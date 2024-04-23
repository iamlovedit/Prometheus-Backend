using Prometheus.Backend.Domain.Entities;
using Roller.Infrastructure.Repository;

namespace Prometheus.Backend.Services;

public interface IDatabaseService : IServiceBase<Database>
{
}

public class DatabaseService : ServiceBase<Database>, IDatabaseService
{
    public DatabaseService(IRepositoryBase<Database> dbContext) : base(dbContext)
    {
    }
}