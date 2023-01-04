
using AutoMapper;
using webapi.test.api;
using webapi.test.domain;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Test, TestDTO>();
    }
}