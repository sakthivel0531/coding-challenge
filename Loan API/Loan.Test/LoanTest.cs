using Loan.API.Controllers;
using Loan.BL;
using Loan.DAL.Repositories;
using Loan.DTO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class LoanTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetAllLoanDetails_ShouldReturn_HttpOk()
        {
            // Arrange
            var mockLoanDetailService = new Mock<ILoanDetailsService>();
            mockLoanDetailService.Setup(s => s.GetAllLoanDetails()).Returns(this.GetAllLoanDetails());
            var controller = new LoanController(mockLoanDetailService.Object);

            // Act
            var controllerResult = controller.GetAllLoanDetails();

            // Assert
            Assert.IsInstanceOf(typeof(OkObjectResult), controllerResult);
        }

        [Test]
        public void GetAllLoanDetails_ShouldReturn_AllLoanDetails()
        {
            // Arrange
            var mockLoanDetailService = new Mock<ILoanDetailsService>();
            mockLoanDetailService.Setup(s => s.GetAllLoanDetails()).Returns(this.GetAllLoanDetails());
            var controller = new LoanController(mockLoanDetailService.Object);

            // Act
            var controllerResult = controller.GetAllLoanDetails() as OkObjectResult;

            // Assert
            var viewResult = controllerResult.Value as List<LoanDetailsViewModel>;
            Assert.AreEqual(this.GetAllLoanDetails(), viewResult);
        }

        private List<LoanDetailsViewModel> GetAllLoanDetails()
        {
            ILoanDetailsRepository loanDetailsRepository = 
                new LoanDetailsRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoanDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return loanDetailsRepository.SelectAll();

        }
    }
}