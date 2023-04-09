using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stolovaya.API.Data;

namespace Stolovaya.API.Controllers.Store
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly StoreDbContext _context;   
        public StoresController(StoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var stores = await _context.Stores.ToListAsync();

            return Ok(stores);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetStore([FromRoute] Guid id)
        {
            var store = await _context.Stores.Where(x => x.Identity == id).FirstOrDefaultAsync();

            if (store is null)
            {
                return Ok("not found store");
            }

            return Ok(store);
        }
    
        [HttpPost]
        public async Task<IActionResult> AddStore([FromBody] Stolovaya.API.Models.Store.Store store)
        {
            store.Identity = Guid.NewGuid();
            await _context.Stores.AddAsync(store);  
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStore),new { id = store.Identity },store);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateStore([FromRoute] Guid id,[FromBody] Stolovaya.API.Models.Store.Store store)
        {
            var storeExist = await _context.Stores.FirstOrDefaultAsync(x=>x.Identity == id);
            if (storeExist is null)
            {
                return Ok($"not found store with Id = {id}");
            }

            storeExist.Name = store.Name;
            storeExist.TimeStart = store.TimeStart;
            storeExist.TimeEnd = store.TimeEnd;

            return Ok(storeExist);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteStore([FromRoute] Guid id)
        {
            var store = await _context.Stores.FirstOrDefaultAsync(x => x.Identity == id);
            if (store is null)
            {
                return Ok($"not found store with Id = {id}");
            }
            _context.Stores.Remove(store);
            await _context.SaveChangesAsync();
            return Ok(store);
        }
    }
}
