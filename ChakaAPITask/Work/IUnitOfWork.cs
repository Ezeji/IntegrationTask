using ChakaAPITask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Work
{
    public interface IUnitOfWork : IDisposable
    {
        IServerRepository Server { get; }
        IStockRepository Stock { get; }
        Task<int> Complete();

    }
}
