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

        [HttpPost]
        public async Task<Order> Post(Order order){
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }

        [HttpGet("{id}")]
        [Route("[action]")]
        public async Task<Order> Get(int id){
            Order chosenOrder = await _context.Order.FirstOrDefaultAsync( order => order.Id == id );
            return chosenOrder;

        }

        [HttpDelete("{id}")]
        public async Task<Order> Delete(int id){
            Order orderToDelete = await _context.Order.FirstAsync( order => order.Id == id );
            _context.Order.Remove( orderToDelete );
            await _context.SaveChangesAsync();
            return orderToDelete;
        }


    }

}