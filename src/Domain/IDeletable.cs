namespace Prometheus.Backend.Domain;

public interface IDeletable
{
    bool IsDeleted { get; set; }
}