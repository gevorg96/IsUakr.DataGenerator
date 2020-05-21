using System.Threading.Tasks;
using IsUakr.DataGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsUakr.DataGenerator.Controllers
{
    [Route("api/meterhubdata")]
    public class MeterHubDataController : Controller
    {
        [HttpPost]
        public async Task<OkResult> Post([FromBody] MeterHubData data)
        {
            return Ok();
        }
    }
}