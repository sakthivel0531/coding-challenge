using Loan.DTO.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan.DAL.Repositories
{
    public interface ILoanRepository
    {
        Task<List<LoanViewModel>> SelectAll();
    }
}