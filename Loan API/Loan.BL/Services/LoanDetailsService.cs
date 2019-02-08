using Loan.DAL.Repositories;
using Loan.DTO.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan.BL
{
    public class LoanDetailsService : ILoanDetailsService
    {
        private readonly ILoanDetailsRepository _loanDetailsRepository;

        public LoanDetailsService(ILoanDetailsRepository loanDetailsRepository)
        {
            this._loanDetailsRepository = loanDetailsRepository;
        }

        public async Task<List<LoanDetailsViewModel>> GetAllLoanDetails()
        {
            return await this._loanDetailsRepository.SelectAll();
        }
    }
}
