using SqlSugar;

namespace Prometheus.Backend.Services;

public interface IDatabaseManager<T, TId> where T : class,ITenant, new()
{
    ISqlSugarClient GetBizDatabase(TId tenantId);

    T GetTenant();
}

public abstract class DatabaseManagerBase<T, TId>(IHttpContextAccessor httpContextAccessor)
    : IDatabaseManager<T, TId> where T : class,ITenant, new()
{
    private SqlSugarScope GetDatabase()
    {
        return (SqlSugarScope)httpContextAccessor.HttpContext.RequestServices.GetService<ISqlSugarClient>();
    }

    public ISqlSugarClient GetBizDatabase(TId tenantId)
    {
        throw new NotImplementedException();
    }

    public abstract T GetTenant();
}