using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;
using LogStore.Repository;

namespace LogStore.Controllers.Controllers
{
    [Route("api/[controller]")]
    public class LogController : Controller
    {
        private static readonly Lazy<ILogRepository> lazy = new Lazy<ILogRepository>(() => new LogRepository());

        public static ILogRepository _logRepository { get { return lazy.Value; } }

        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            await Task.Run(() => _logRepository.Log("test"));
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public async Task<string> Post([FromBody] string value)
        {
            return string.Empty;
        }
    }
}
