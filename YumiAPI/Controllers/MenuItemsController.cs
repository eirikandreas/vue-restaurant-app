using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YumiAPI.Models;
using System.Linq;

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

        [HttpPost]
        public async Task<MenuItem> Post(MenuItem menuItem){
            _context.MenuItem.Add(menuItem);
            await _context.SaveChangesAsync();
            return menuItem;
        }

    }

}