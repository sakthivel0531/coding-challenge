using System.Collections.Generic;
using System.Threading.Tasks;
using Loan.DTO.ViewModels;

namespace Loan.DAL.Repositories
{
    public interface ILoanRepository
    {
        Task<List<LoanViewModel>> SelectAll();
    }
}