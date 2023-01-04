
using AutoMapper;
using webapi.test.domain;

namespace webapi.test.api;

public class TestAdapterImpl : ITestAdapter {

    private readonly ITestService _service;
    private readonly IMapper _mapper;

    public TestAdapterImpl(ITestService service, IMapper mapper) {
        _service = service;
        _mapper = mapper;
    }

    public TestDTO GetTest(uint id) {
        Test source = _service.GetTest(id);
        return _mapper.Map<Test, TestDTO>(source);
    }
}