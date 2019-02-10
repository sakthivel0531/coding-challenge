import { ILoanDetailsModel } from '../models/loan-model';

export interface ILoanState {
    loanDetailList: ILoanDetailsModel[];
    totalLoan: number;
}

export const INITIAL_LOAN_STATE: ILoanState = {
    loanDetailList: [],
    totalLoan: 0
};

