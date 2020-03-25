using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YumiAPI.Models;
using System.Linq;

namespace YumiAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase{
        
        private readonly YumiContext _context;
        public OrdersController(YumiContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> Get(){
            List<Order> orderList = await _context.Order.ToListAsync();
            return orderList;
        }

    }

}