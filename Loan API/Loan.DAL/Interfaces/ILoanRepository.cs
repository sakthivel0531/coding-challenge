using Loan.DTO.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan.DAL.Repositories
{
    public interface ILoanRepository
    {
        List<LoanViewModel> SelectAll();
    }
}