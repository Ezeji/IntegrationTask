using Moq;
using NUnit.Framework;
using ChakaAPITask.Work;
using System.Threading.Tasks;
using ChakaAPITask.Model;
using ChakaAPITask.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ChakaAPITask.UnitTests.Mock
{
    [TestFixture]
    public class QuestionOneControllerTests
    {
        [Test]
        public async Task GetStocks_ReturnsOk()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(questionOne => questionOne.Stock.FetchStockDetails(new Stock())).ReturnsAsync("result");

            var questionOneController = new QuestionOneController(unitOfWork.Object);

            var result = await questionOneController.GetStocks(new Stock());
            var okResult = new OkObjectResult(result);

            Assert.AreEqual(200, okResult.StatusCode);
        }
    }
}