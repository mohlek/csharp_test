
using webapi.test.domain;

namespace webapi.test.repository;

public class TestRepository : IFindTest
{
    public Test ById(uint id) {
        Test _ = new();
        _.id = id;
        _.name = "Test123";
        return _;
    }
}