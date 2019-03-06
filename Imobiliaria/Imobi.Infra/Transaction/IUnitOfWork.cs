namespace Imobi.Infra.Transaction
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
