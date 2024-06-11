namespace SaleKiosk.Domain.Contracts
{
    public interface IKioskUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
        IUserRepository UserRepository { get; }

        void Commit();
    }
}
