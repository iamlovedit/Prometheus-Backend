using SqlSugar;

namespace Prometheus.Backend.Domain.Entities;

[SugarTable("tenant_database")]
public class Database : IDeletable
{
    [SugarColumn(IsPrimaryKey = true, ColumnName = "database_id")]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "database_connectionString", IsNullable = false)]
    public string ConnectionString { get; set; }

    [SugarColumn(ColumnName = "database_productionId")]
    public long ProductionId { get; set; }

    [Navigate(NavigateType.OneToOne, nameof(ProductionId))]
    public Production Production { get; set; }

    [SugarColumn(ColumnName = "database_isDeleted")]
    public bool IsDeleted { get; set; }
}