using ChakaAPITask.Data;
using ChakaAPITask.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Repository
{
    public class StockRepository : IStockRepository
    {
        private ChakaDBContext _context;

        public StockRepository(ChakaDBContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Fetches stock details from stock table in the database.
        /// </summary>
        /// <param name="stock">Stock Object</param>
        public async Task<dynamic> FetchStockDetails(Stock stock)
        {
            Stock[] stockDetails = await _context.Stocks.FromSqlRaw($"GetStock {stock.UserId},{stock.MerchantId}")
                                                    .ToArrayAsync();

            stockDetails = stockDetails.OrderByDescending(date => date.CreatedDate).ToArray();

            return stockDetails;
            
        }

        
    }
}
