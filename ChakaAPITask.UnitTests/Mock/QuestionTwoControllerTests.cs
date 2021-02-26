using ChakaAPITask.Controllers;
using ChakaAPITask.Model;
using ChakaAPITask.Work;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChakaAPITask.UnitTests.Mock
{
    [TestFixture]
    public class QuestionTwoControllerTests
    {
        [Test]
        public void UpdateServers_ReturnsOk()
        {
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(questionTwo => questionTwo.Server.NumberOfDaysToUpdateServers(new Server())).Returns("result");

            var questionTwoController = new QuestionTwoController(unitOfWork.Object);

            var result = questionTwoController.UpdateServers(new Server());
            var okResult = new OkObjectResult(result);

            Assert.AreEqual(200, okResult.StatusCode);
        }

    }
}
