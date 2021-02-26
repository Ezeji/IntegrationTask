using ChakaAPITask.Data;
using ChakaAPITask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Work
{
    public class UnitOfWork : IUnitOfWork
    {
        private ChakaDBContext _context;

        public IServerRepository Server { get; }
        public IStockRepository Stock { get; }

        public UnitOfWork(ChakaDBContext context)
        {
            _context = context;
            Server = new ServerRepository(_context);
            Stock = new StockRepository(_context);
        }

        public async Task<int> Complete()
        {
            var result = await _context.SaveChangesAsync();

            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

    }
}
