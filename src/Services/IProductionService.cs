using Prometheus.Backend.Domain.Entities;
using Roller.Infrastructure.Repository;
namespace Prometheus.Backend.Services;

public interface IProductionService:IServiceBase<Production>
{
    
}

public class ProductionService(IRepositoryBase<Production> dbContext)
    : ServiceBase<Production>(dbContext), IProductionService;