using ChakaAPITask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Repository
{
    public interface IStockRepository
    {
        Task<dynamic> FetchStockDetails(Stock stock);
    }
}
