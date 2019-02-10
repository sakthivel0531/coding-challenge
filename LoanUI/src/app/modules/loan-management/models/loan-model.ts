export interface ILoanDetailsModel {
    loanId: number;
    totalLoan: number;
    loanName: string;
    balance: number;
    balanceWithInterest: number;
    repaymentFee: number;
    payoutCarryOverAmount: number;
}
