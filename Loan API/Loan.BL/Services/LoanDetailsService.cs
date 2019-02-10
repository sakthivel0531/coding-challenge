using Loan.DAL.Repositories;
using Loan.DTO.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan.BL
{
    /// <summary>
    /// Get loan and it's details.
    /// </summary>
    public class LoanDetailsService : ILoanDetailsService
    {
        private readonly ILoanDetailsRepository _loanDetailsRepository;

        public LoanDetailsService(ILoanDetailsRepository loanDetailsRepository)
        {
            this._loanDetailsRepository = loanDetailsRepository;
        }

        /// <summary>
        /// Get all loan details.
        /// </summary>
        /// <returns></returns>
        public List<LoanDetailsViewModel> GetAllLoanDetails()
        {
            return this._loanDetailsRepository.SelectAll();
        }
    }
}
