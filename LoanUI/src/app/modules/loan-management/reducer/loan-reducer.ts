import { LoanActions } from '../action/loan-action';

export function rootReducer(state, action) {
    switch (action.type) {
        case LoanActions.addNewLoan:
            return Object.assign({}, state, {});
        case LoanActions.getLoanDetails:
            return Object.assign({}, state, {
                loanDetailList: action.todo,
                totalLoan: action.todo.length
            });
    }
}
