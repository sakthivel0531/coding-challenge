using Loan.BL;
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
        public async Task<IActionResult> GetAllLoanDetails()
        {
            try
            {
                return Ok(await this._loanDetailsService.GetAllLoanDetails());
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}