using Loan.DTO.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan.BL
{
    public interface ILoanDetailsService
    {
        Task<List<LoanDetailsViewModel>> GetAllLoanDetails();
    }
}