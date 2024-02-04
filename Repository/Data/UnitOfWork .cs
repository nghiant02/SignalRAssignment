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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzaStoreContext _context;
        public IAccountRepository Account {  get; private set; }
        public ICategoryRepository Category { get; private set; }
        public ICustomerRepository Customer { get; private set; }
        public IOrderRepository Order { get; private set; }
        public IOrder_DetailRepository Order_Detail { get; private set; }
        public IProductRepository Product { get; private set; }
        public ISupplierRepository Supplier { get; private set; }

        public UnitOfWork(PizzaStoreContext context)
        {
            _context = context;
            Account = new AccountRepository(_context);
            Category = new CategoryRepository(_context);
            Customer = new CustomerRepository(_context);
            Order = new OrderRepository(_context);
            Order_Detail = new Order_DetailRepository(_context);
            Product = new ProductRepository(_context);
            Supplier = new SupplierRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
