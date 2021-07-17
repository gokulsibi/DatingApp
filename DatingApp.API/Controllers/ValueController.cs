using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ValueController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _dataContext.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _dataContext.Values.FirstOrDefaultAsync(x=> x.Id == id);
            return  Ok(value);
        }


    }
}