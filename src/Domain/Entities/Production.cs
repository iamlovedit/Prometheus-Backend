using SqlSugar;

namespace Prometheus.Backend.Domain.Entities;

public interface ITenant
{
    public long DatabaseId { get; set; }
}

[SugarTable("tenant_production")]
public class Production : IDeletable, ITenant
{
    [SugarColumn(IsPrimaryKey = true, ColumnName = "production_id")]
    public long Id { get; set; }

    [SugarColumn(ColumnName = "production_name")]
    public string Name { get; set; }

    [SugarColumn(ColumnName = "production_isDeleted")]
    public bool IsDeleted { get; set; }

    [SugarColumn(ColumnName = "production_databaseId")]
    public long DatabaseId { get; set; }

    [Navigate(NavigateType.OneToOne, nameof(DatabaseId))]
    public Database Database { get; set; }
}