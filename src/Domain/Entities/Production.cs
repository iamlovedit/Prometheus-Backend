using SqlSugar;

namespace Prometheus.Backend.Domain.Entities;

[SugarTable("tenant_production")]
public class Production : IDeletable
{
    [SugarColumn(IsPrimaryKey = true,ColumnName = "production_id")]
    public long Id { get; set; }
    
    [SugarColumn(ColumnName = "production_name")]
    public string Name { get; set; }

    [SugarColumn(ColumnName = "production_isDeleted")]
    public bool IsDeleted { get; set; }
}