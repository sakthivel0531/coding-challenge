import { LoanActions } from '../action/loan-action';

export function rootReducer(state, action) {
    switch (action.type) {
        case LoanActions.addNewLoan:
            return Object.assign({}, state, {});
        case LoanActions.getLoanDetails:
            return Object.assign({}, state, {
                loanDetailList: action.todo,
                totalLoan: action.todo.length,
                totalPayoutCarryOverAmount: 0
            });
        case LoanActions.addPayoutCarryOverAmount:
            let newTotalPayoutCarryOverAmount = state.totalPayoutCarryOverAmount + action.todo;
            return Object.assign({}, state, {
                totalPayoutCarryOverAmount: newTotalPayoutCarryOverAmount
            });
        case LoanActions.minusPayoutCarryOverAmount:
            newTotalPayoutCarryOverAmount = state.totalPayoutCarryOverAmount - action.todo;
            return Object.assign({}, state, {
                totalPayoutCarryOverAmount: newTotalPayoutCarryOverAmount
            });
    }
}
