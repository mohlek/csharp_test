using webapi.test.domain;

namespace webapi.test.service;

public class TestServiceImpl : ITestService {

    private readonly IFindTest _iFindTest;

    public TestServiceImpl(IFindTest iFindTest) {
        _iFindTest = iFindTest;
    }

    public Test GetTest(uint id) {
        return _iFindTest.ById(id);
    }
}