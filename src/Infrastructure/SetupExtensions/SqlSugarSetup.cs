using Prometheus.Backend.Domain;
using SqlSugar;

namespace Prometheus.Backend.Infrastructure.SetupExtensions;

public static class SqlSugarSetup
{
    public static void AddSqlSugarSetup(this IServiceCollection services, IConfiguration configuration,
        IWebHostEnvironment hostEnvironment)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configuration);
        ArgumentNullException.ThrowIfNull(hostEnvironment);

        var connectionString =
            $"server={configuration["POSTGRESQL_HOST"]};" +
            $"port={configuration["POSTGRESQL_PORT"]};" +
            $"database={configuration["POSTGRESQL_DATABASE"]};" +
            $"userid={configuration["POSTGRESQL_USER"]};" +
            $"password={configuration["POSTGRESQL_PASSWORD"]};";

        var connectionConfig = new ConnectionConfig()
        {
            DbType = DbType.PostgreSQL,
            ConnectionString = connectionString,
            InitKeyType = InitKeyType.Attribute,
            IsAutoCloseConnection = true,
            MoreSettings = new ConnMoreSettings()
            {
                PgSqlIsAutoToLower = false,
                PgSqlIsAutoToLowerCodeFirst = false,
            }
        };

        var sugarScope = new SqlSugarScope(connectionConfig, config =>
        {
            config.QueryFilter.AddTableFilter<IDeletable>(d => !d.IsDeleted);
            if (hostEnvironment.IsDevelopment() || hostEnvironment.IsStaging())
            {
                config.Aop.OnLogExecuting = (sql, parameters) => { Console.WriteLine(sql); };
            }
        });

        services.AddSingleton<ISqlSugarClient>(sugarScope);
    }
}