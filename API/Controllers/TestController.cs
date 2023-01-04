using Microsoft.AspNetCore.Mvc;
using webapi.test.domain;

namespace webapi.test.api;

[Route("[controller]")]
[ApiController]
public class TestController : ControllerBase {

    private readonly ILogger<TestController> _logger;
    private readonly ITestAdapter _service;

    public TestController(ILogger<TestController> logger, ITestAdapter testService) {
        _logger = logger;
        _service = testService;
    }

    [HttpGet("{id}")]
    public TestDTO? GetTestDTO(uint id) {
        return _service.GetTest(id);
    }
}