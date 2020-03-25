using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YumiAPI.Models;
using System.Linq;

namespace YumiAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase{
        
        private readonly YumiContext _context;
        public UsersController(YumiContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get(){
            List<User> userList = await _context.User.ToListAsync();
            return userList;
        }

        [HttpGet("{isadmin}")]
        public async Task<User> Get(string isadmin){
            User isAdmin = await _context.User.FirstOrDefaultAsync( user => user.IsAdmin == isadmin );
            return isAdmin;
        }

        [HttpPost]
        public async Task<User> Post( User email){
            _context.User.Add( email );
            await _context.SaveChangesAsync();
            return email;

        }

    }

}