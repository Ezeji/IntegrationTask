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
    public class QuestionTwoController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public QuestionTwoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // POST: api/v1/QuestionTwo
        [HttpPost("[action]")]
        public IActionResult UpdateServers([FromForm] Server server)
        {
            var result = _unitOfWork.Server.NumberOfDaysToUpdateServers(server);

            return Ok(result);
        }

    }
}
