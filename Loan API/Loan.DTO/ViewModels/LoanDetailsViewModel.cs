namespace Loan.DTO.ViewModels
{
    /// <summary>
    /// Loan details view model.
    /// </summary>
    public class LoanDetailsViewModel : LoanViewModel
    {
        public decimal Balance { get; set; }
        public decimal BalanceWithInterest { get; set; }
        public decimal RepaymentFee { get; set; }
    }
}
