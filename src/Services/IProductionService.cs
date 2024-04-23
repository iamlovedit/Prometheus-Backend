using Prometheus.Backend.Domain.Entities;
using Roller.Infrastructure.Repository;
namespace Prometheus.Backend.Services;

public interface IProductionService:IServiceBase<Production>
{
    
}

public class ProductionService : ServiceBase<Production>, IProductionService
{
    public ProductionService(IRepositoryBase<Production> dbContext) : base(dbContext)
    {
    }
}