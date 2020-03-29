using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YumiAPI.Models;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace YumiAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class MenuItemsController : ControllerBase{
        
        private readonly YumiContext _context;
        public MenuItemsController(YumiContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<MenuItem>> Get(){
            List<MenuItem> menuItemList = await _context.MenuItem.ToListAsync();
            return menuItemList;     
        }

        [HttpGet("{id}")]
        public async Task<MenuItem> Get(int id){
            MenuItem chosenMenuItem = await _context.MenuItem.FirstOrDefaultAsync( menuItem => menuItem.Id == id );
            return chosenMenuItem;

        }

        [HttpPut]
        public async Task<MenuItem> Put(MenuItem updateMenuItem){
            _context.Update(updateMenuItem);
            await _context.SaveChangesAsync();
            return updateMenuItem;
        }

        [HttpDelete("{id}")]
        public async Task<MenuItem> Delete(int id){
            MenuItem menuItemToDelete = await _context.MenuItem.FirstAsync( menuItem => menuItem.Id == id );
            _context.MenuItem.Remove( menuItemToDelete );
            await _context.SaveChangesAsync();
            return menuItemToDelete;
        }

        [HttpPost]
        public async Task<MenuItem> Post(MenuItem menuItem){
            _context.MenuItem.Add(menuItem);
            await _context.SaveChangesAsync();
            return menuItem;
        }



        // END

    }

}