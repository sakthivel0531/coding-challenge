﻿using Loan.DTO.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Loan.DAL.Repositories
{
    public interface ILoanDetailsRepository
    {
        Task<List<LoanDetailsViewModel>> SelectAll();
    }
}