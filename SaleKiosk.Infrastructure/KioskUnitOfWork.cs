using SaleKiosk.Domain.Contracts;

namespace SaleKiosk.Infrastructure
{
    // implementacja Unit of Work
    public class KioskUnitOfWork : IKioskUnitOfWork
    {
        private readonly KioskDbContext _context;

        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }

        public KioskUnitOfWork(KioskDbContext context, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            this._context = context;
            this.ProductRepository = productRepository;
            this.OrderRepository = orderRepository;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
