export interface ILoanDetailsModel {
    loanId: number;
    totalLoan: number;
    loanName: string;
    loanNumber: string;
    balance: number;
    balanceWithInterest: number;
    repaymentFee: number;
    payoutCarryOverAmount: number;
}
