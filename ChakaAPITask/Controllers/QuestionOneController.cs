using ChakaAPITask.Model;
using ChakaAPITask.Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class QuestionOneController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public QuestionOneController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // POST: api/v1/QuestionOne
        [HttpPost("[action]")]
        public async Task<IActionResult> GetStocks([FromForm] Stock stock)
        {
            var result = await _unitOfWork.Stock.FetchStockDetails(stock);

            return Ok(result);
        }

    }
}
