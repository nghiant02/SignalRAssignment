using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class Order_DetailRepository : GenericRepository<Order_Detail>, IOrder_DetailRepository
    {
        public Order_DetailRepository(PizzaStoreContext _context) : base(_context) { }
    }
}
