using Xunit;

namespace FmWkPlugin_Services.Tests
{
  public class FmWkPluginServiceTest
  {
    private readonly FmWkPluginService _service;

    public FmWkPluginServiceTest()
    {
      _service = new FmWkPluginService();
    }
    [Fact]
    public void TestServiceWtf()
    {
      Assert.Equal(_service.Test().Wtf, "test");
    }
  }
}