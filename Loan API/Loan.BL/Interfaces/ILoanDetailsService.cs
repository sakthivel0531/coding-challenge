using System.Collections.Generic;
using System.Threading.Tasks;
using Loan.DTO.ViewModels;

namespace Loan.BL
{
    public interface ILoanDetailsService
    {
        Task<List<LoanDetailsViewModel>> GetAllLoanDetails();
    }
}