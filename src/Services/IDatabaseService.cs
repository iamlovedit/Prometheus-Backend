using Prometheus.Backend.Domain.Entities;
using Roller.Infrastructure.Repository;

namespace Prometheus.Backend.Services;

public interface IDatabaseService : IServiceBase<Database>
{
}

public class DatabaseService(IRepositoryBase<Database> dbContext) : ServiceBase<Database>(dbContext), IDatabaseService;