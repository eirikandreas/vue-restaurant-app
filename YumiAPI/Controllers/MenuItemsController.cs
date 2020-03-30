using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YumiAPI.Models;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace YumiAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class MenuItemsController : ControllerBase{
        
        private readonly YumiContext _context;

        private readonly IWebHostEnvironment _hosting;
        public MenuItemsController(YumiContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
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

        // Image Uploader

        [HttpPost]
        [Route("[action]")]
        public void SavePicture(IFormFile file){
            string webrootpath = _hosting.WebRootPath;
            string absolutepath = Path.Combine($"{webrootpath}/images/{file.FileName}");
            using(var filestream = new FileStream(absolutepath, FileMode.Create)){
                file.CopyTo(filestream);
            }
        }



        // END

    }

}