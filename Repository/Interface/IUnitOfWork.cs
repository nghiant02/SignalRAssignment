using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Account { get; }
        ICategoryRepository Category { get; }
        ICustomerRepository Customer { get; }
        IOrderRepository Order { get; }
        IOrder_DetailRepository Order_Detail { get; }
        IProductRepository Product { get; }
        ISupplierRepository Supplier { get; }
        Task<int> CompleteAsync();
    }
}
