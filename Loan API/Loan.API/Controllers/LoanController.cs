using Loan.BL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Loan.API.Controllers
{
    /// <summary>
    /// Get loan and it's details.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LoanController : Controller
    {
        private readonly ILoanDetailsService _loanDetailsService;

        public LoanController(ILoanDetailsService loanDetailsService)
        {
            this._loanDetailsService = loanDetailsService;
        }

        /// <summary>
        /// Get all loan details.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllLoanDetails")]
        public IActionResult GetAllLoanDetails()
        {
            try
            {
                var result = this._loanDetailsService.GetAllLoanDetails();
                return Ok(result);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}