using AutoMapper;
using Prometheus.Backend.Domain.DataTransferObjects;

namespace Prometheus.Backend.Domain;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Version, VersionDTO>();
    }
}