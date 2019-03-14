using Imobi.Infra.Persistence;

namespace Imobi.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ImobiContext _context;

        public UnitOfWork(ImobiContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
