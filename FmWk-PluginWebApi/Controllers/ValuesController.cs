using System.Collections.Generic;
using FmWkPlugin_Services;
using Microsoft.AspNetCore.Mvc;

namespace FmWk_PluginWebApi.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    private readonly FmWkPluginService _fmWkPluginService;

    public ValuesController(FmWkPluginService service)
    {
      _fmWkPluginService = service;
    }
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new[] {"value1", "value2"};
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return _fmWkPluginService.Test().Wtf;
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}