namespace SaleKiosk.Domain.Contracts
{
    public interface IKioskUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }

        void Commit();
    }
}
