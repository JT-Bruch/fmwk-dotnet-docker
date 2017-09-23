using FmWkPlugin_Entities;

namespace FmWkPlugin_Services
{
  public class FmWkPluginService
  {
    public FmWkPluginBaseEntity Test()
    {
      return new FmWkPluginBaseEntity() { Wtf = "test" };
    }
  }
}