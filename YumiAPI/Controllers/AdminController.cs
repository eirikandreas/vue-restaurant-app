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
    public class AdminController : ControllerBase{
        
        private readonly YumiContext _context;

        private readonly IWebHostEnvironment _hosting;
        public AdminController(YumiContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
        }

        // ADMIN TILGANGER FOR ALLE RETTENE I APIET

        // Henter rettene i menyen
        [HttpGet("menuitems")]
        [Route("[action]")]
        public async Task<IEnumerable<MenuItem>> Get(){
            List<MenuItem> menuItemList = await _context.MenuItem.ToListAsync();
            return menuItemList;     
        }

        // Henter retter basert på id og returnerer valgt rett
        [HttpGet("menuitems/{id}")]
        [Route("[action]")]
        public async Task<MenuItem> Get(int id){
            MenuItem chosenMenuItem = await _context.MenuItem.FirstOrDefaultAsync( menuItem => menuItem.Id == id );
            return chosenMenuItem;
        }

        // Oppdatere rett i menyen
        [HttpPut("menuitems")]
        public async Task<MenuItem> Put(MenuItem updateMenuItem){
            _context.Update(updateMenuItem);
            await _context.SaveChangesAsync();
            return updateMenuItem;
        }

        // Slett rett basert på id, returnerer hvilken rett som skal slettes
        [HttpDelete("menuitems/{id}")]
        public async Task<MenuItem> Delete(int id){
            MenuItem menuItemToDelete = await _context.MenuItem.FirstAsync( menuItem => menuItem.Id == id );
            _context.MenuItem.Remove( menuItemToDelete );
            await _context.SaveChangesAsync();
            return menuItemToDelete;
        }

        // Legger til en rett i menyen
        [HttpPost("menuitems")]
        public async Task<MenuItem> Post(MenuItem menuItem){
            _context.MenuItem.Add(menuItem);
            await _context.SaveChangesAsync();
            return menuItem;
        }

        // Laster opp et bilde til webrootpath = wwwroot med fil og filnavn
        [HttpPost]
        [Route("[action]")]
        public void SavePicture(IFormFile file){
            string webrootpath = _hosting.WebRootPath;
            string absolutepath = Path.Combine($"{webrootpath}/images/{file.FileName}");
            using(var filestream = new FileStream(absolutepath, FileMode.Create)){
                file.CopyTo(filestream);
            }
        }

        // ADMIN TILGANGER FOR ORDRE I APIET

        // Gir tilgang til alle ordre
        [HttpGet("orders")]
        [Route("[action]")]
        public async Task<IEnumerable<Order>> GetOrders(){
            List<Order> orderList = await _context.Order.ToListAsync();
            return orderList;
        }
        // Slett en ordre basert på id, returnerer hvilken ordre som skal slettes
        [HttpDelete("orders/{id}")]
        public async Task<Order> DeleteOrder(int id){
            Order orderToDelete = await _context.Order.FirstAsync( order => order.Id == id );
            _context.Order.Remove( orderToDelete );
            await _context.SaveChangesAsync();
            return orderToDelete;
        }
        // ADMIN TILGANGER FOR ContactMessages I APIET

        // Gir tilgang til Contact Messages
        [HttpGet("messages")]
        public async Task<IEnumerable<ContactMessage>> GetContactMessages(){
            List<ContactMessage> ContactMessageList = await _context.ContactMessage.ToListAsync();
            return ContactMessageList;     
        }

        // Gir tilgang til å endre Contact Messages
        [HttpPut("messages")]
        public async Task<ContactMessage> Put(ContactMessage updateContactMessage){
            _context.Update(updateContactMessage);
            await _context.SaveChangesAsync();
            return updateContactMessage;
        }

        // Slett en message basert på id, returnerer hvilken message som skal slettes
        [HttpDelete("messages/{id}")]
        public async Task<ContactMessage> DeleteMessage(int id){
            ContactMessage ContactMessageToDelete = await _context.ContactMessage.FirstAsync( ContactMessage => ContactMessage.Id == id );
            _context.ContactMessage.Remove( ContactMessageToDelete );
            await _context.SaveChangesAsync();
            return ContactMessageToDelete;
        }
        // Gir tilgang til å hente ut data basert på Id i PageSettings
       [HttpGet("pagesettings/{id}")]
        public async Task<PageSettings> GetPageSetting(int id){
            PageSettings PageSettings = await _context.PageSettings.FirstOrDefaultAsync( _PageSettings => _PageSettings.Id == id );
            return PageSettings;
        }

        // Legger til data i PageSettings
        [HttpPost("pagesettings")]
        public async Task<PageSettings> Post(PageSettings PageSettings){
            _context.PageSettings.Add(PageSettings);
            await _context.SaveChangesAsync();
            return PageSettings;
        }

        // Endre data i PageSettings
        [HttpPut("pagesettings")]
        public async Task<PageSettings> Put(PageSettings updatePage){
            _context.Update(updatePage);
            await _context.SaveChangesAsync();
            return updatePage;
        }

    }

}