using System;
using System.Collections.Generic;
using System.Text;

namespace Loan.DTO.ViewModels
{
    public class LoanDetailsViewModel : LoanViewModel
    {
        public decimal Balance { get; set; }
        public decimal BalanceWithInterest { get; set; }
        public decimal RepaymentFee { get; set; }
    }
}
