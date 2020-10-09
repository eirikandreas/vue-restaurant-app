using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YumiAPI.Models;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

namespace YumiAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase{

        // USER TILGANGER FOR ALLE RETTENE I APIET
        private readonly YumiContext _context;

        private readonly IWebHostEnvironment _hosting;
        public UserController(YumiContext context, IWebHostEnvironment hosting){
            _context = context;
            _hosting = hosting;
        }

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

        // Henter rettene i menyen basert på kategori
        [HttpGet("menuitems/category/{category}")]
        [Route("[action]")]
        public async Task<IEnumerable<MenuItem>> GetCategory(string category){
            List<MenuItem> menuItemCategory = await _context.MenuItem
                .Where( 
                    menuItem => menuItem.Category.ToLower()
                    .Contains(category.ToLower()) 
                )
                .ToListAsync();

            return menuItemCategory;
        }
        // Henter rettene i menyen basert på tittel
        [HttpGet("menuitems/title/{title}")]
        [Route("[action]")]
        public async Task<IEnumerable<MenuItem>> GetTitle(string title){
            List<MenuItem> menuItemList = await _context.MenuItem
                .Where( 
                    menuItem => menuItem.Title.ToLower()
                    .Contains(title.ToLower()) 
                )
                .ToListAsync();

            return menuItemList;
        }
        
        // Oppdatere rating i menyen
        [HttpPut("menuitems")]
        public async Task<MenuItem> Put(MenuItem updateMenuItem){
            _context.Update(updateMenuItem);
            await _context.SaveChangesAsync();
            return updateMenuItem;
        }

        // USER TILGANGER FOR PAGESETTINGS

        // Gir tilgang til å hente ut data basert på Id i PageSettings
       [HttpGet("pagesettings/{id}")]
        public async Task<PageSettings> GetPageSetting(int id){
            PageSettings PageSettings = await _context.PageSettings.FirstOrDefaultAsync( _PageSettings => _PageSettings.Id == id );
            return PageSettings;
        }

        // USER TILGANGER FOR CONTACTMESSAGES
        
        // Gir tilgang til å legge inn data i ContactMessage modellen
        [HttpPost("contactmessages")]
        public async Task<ContactMessage> Post(ContactMessage ContactMessage){
            _context.ContactMessage.Add(ContactMessage);
            await _context.SaveChangesAsync();
            return ContactMessage;
        }

        // USER TILGANGER FOR ORDERS

        // Gir til å legge til data i Order modellen
        [HttpPost("orders")]
        public async Task<Order> Post(Order order){
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

    }

}