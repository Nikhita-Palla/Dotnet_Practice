using EntityFramework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyTypeController : ControllerBase
    {
        private readonly AppDBContext appDBContext;
        public CurrencyTypeController(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;

        }

        [HttpGet("")]
        public IActionResult GetAllCurrencies()
        {
            var result = appDBContext.CurrencyTypes.ToList();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCurrencyById([FromRoute] int id)
        {
            var result=appDBContext.CurrencyTypes.FirstOrDefault(x => x.Id == id);
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCurrencyByName([FromRoute] string name, [FromRoute] string? Description)
        {
            var result = await appDBContext.CurrencyTypes.Where(x => x.Currency == name
            && (string.IsNullOrEmpty(Description) || x.Description== Description)).FirstOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost("all")]
        public async Task<IActionResult> GetCurrencyByIds([FromBody] List<int> ids)
        {
           
            var result=await appDBContext.CurrencyTypes.Where(x=>ids.Contains(x.Id)).ToListAsync();
            return Ok(result);
        }

        
    }
}
